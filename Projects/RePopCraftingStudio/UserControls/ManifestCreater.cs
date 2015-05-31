using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RePopCraftingStudio.Db;

namespace RePopCraftingStudio.UserControls
{
   public partial class ManifestCreater : OurUserControl
   {
      private bool _updating = false;
      private CraftableEntity _rootEntity;

      public ManifestCreater()
      {
         InitializeComponent();
      }

      //public event EventHandler<EntitySelectedEventArgs> EntitySelected;

      //protected virtual void OnEntitySelected( EntitySelectedEventArgs e )
      //{
      //   EventHandler<EntitySelectedEventArgs> handler = EntitySelected;
      //   if ( handler != null )
      //      handler( this, e );
      //}

      public event EventHandler<ObjectSelectedEventArgs> ObjectSelected;

      protected virtual void OnObjectSelected( ObjectSelectedEventArgs e )
      {
         EventHandler<ObjectSelectedEventArgs> handler = ObjectSelected;
         if ( handler != null )
            handler( this, e );
      }

      public override void LoadSettings()
      {
         manifestSplitContainer.SplitterDistance = Properties.Settings.Default.ManifestViewSplitterDistance;
         recipeSinglePanel.BackColor = Properties.Settings.Default.RecipeSingleBackColor;
         agentGatheredPanel.BackColor = Properties.Settings.Default.AgentGatheredBackColor;
         ingredientGatheredPanel.BackColor = Properties.Settings.Default.IngredientGatheredBackColor;
         recipeMultiplePnel.BackColor = Properties.Settings.Default.RecipeMultipleBackColor;
         agentCraftedPanel.BackColor = Properties.Settings.Default.AgentCraftedBackColor;
         ingredientCraftedPanel.BackColor = Properties.Settings.Default.IngredientCraftedBackColor;
         agentComponentPanel.BackColor = Properties.Settings.Default.AgentComponentBackColor;

         base.LoadSettings();
      }

      public override void SaveSettings()
      {
         base.SaveSettings();

         Properties.Settings.Default.ManifestViewSplitterDistance = manifestSplitContainer.SplitterDistance;
      }

      public Entity RootEntity
      {
         //get { return _rootEntity; }
         set
         {
            _rootEntity = new CraftableEntity( (NamedEntity)value );
            StartTheProcess();
         }
      }

      private void theTreeView_AfterSelect( object sender, TreeViewEventArgs e )
      {
         OnObjectSelected( new ObjectSelectedEventArgs( null == e.Node ? null : e.Node.Tag ) );
      }

      private void theTreeView_AfterCheck( object sender, TreeViewEventArgs e )
      {
         if ( _updating )
            return;

         _updating = true;
         TreeNodeCollection nodes = null == e.Node.Parent ? theTreeView.Nodes : e.Node.Parent.Nodes;
         for ( int i = 0; i < nodes.Count; i++ )
         {
            nodes[ i ].Checked = i == e.Node.Index;
         }
         _updating = false;
      }

      // NOTE: Need better name
      private void StartTheProcess()
      {
         try
         {
            theTreeView.BeginUpdate();
            _updating = true;

            theTreeView.Nodes.Clear();
            if ( null == _rootEntity.Entity )
               return;

            TreeNode root = theTreeView.Nodes.Add( _rootEntity.Name );
            root.Tag = _rootEntity;

            AddRecipes( root, _rootEntity.Id, _rootEntity.EntityType );

            root.ExpandAll();
            BuildManifest();
         }
         finally
         {
            theTreeView.EndUpdate();
            _updating = false;
         }
      }

      private void AddRecipes( TreeNode entityNode, long entityId, EntityTypes entityType )
      {
         IEnumerable<Recipe> recipes = Db.SelectRecipesByResultIdandType( entityId, entityType );
         if ( !recipes.Any() )
            return;

         AddRecipeToNode( entityNode, recipes, recipes.First(), entityId );
      }

      private void AddRecipeToNode( TreeNode parentNode, IEnumerable<Recipe> recipes, Recipe recipe, long entityId )
      {
         TreeNode child = parentNode.Nodes.Add( string.Format( @"R: {0} ({1})", recipe.Name, recipe.SkillName ) );
         child.Tag = recipe;

         if ( recipes.Count() > 1 )
         {
            string toolTipText = "Potential Recipes:\n\n";
            ContextMenu menu = new ContextMenu();
            int index = 1;
            foreach ( Recipe rec in recipes )
            {
               menu.MenuItems.Add( new MenuItem( rec.Name, ( sender, args ) =>
               {
                  parentNode.Nodes.Clear();
                  AddRecipeToNode( parentNode, recipes, rec, entityId );
                  parentNode.ExpandAll();
               } ) );
               toolTipText += string.Format( "{0} - {1}\n", index++, rec.Name );
            }

            child.ContextMenu = menu;
            child.ToolTipText = toolTipText;
         }
         ManifestTreeNodeThemes.Apply( parentNode );

         AddRecipeResults( child, entityId );
      }

      private void AddRecipeResults( TreeNode recipeNode, long resultId )
      {
         Recipe recipe = (Recipe)recipeNode.Tag;
         IEnumerable<RecipeResult> recipeResults = Db.SelectRecipeResultsForRecipeAndResult( recipe.RecipeId, resultId );
         Debug.Assert( recipeResults.Any() );

         AddRecipeResultsToNode( recipeNode, recipeResults, recipeResults.First() );

         recipeNode.ExpandAll();
      }

      private void AddRecipeResultsToNode( TreeNode parentNode, IEnumerable<RecipeResult> recipeResults, RecipeResult recipeResult )
      {
         if ( recipeResults.Count() > 1 )
         {
            parentNode.Text += @" - " + Db.GetIngredientSlotsInfoForRecipeResult( recipeResult ).GetSpecificItemNames();

            string toolTipText = "Potential Result Combos:\n\n";
            ContextMenu menu = new ContextMenu();
            int index = 1;
            foreach ( RecipeResult rec in recipeResults )
            {
               IEnumerable<IngredientSlotInfo> infos = Db.GetIngredientSlotsInfoForRecipeResult( rec );
               menu.MenuItems.Add( new MenuItem( infos.GetSpecificItemNames(), ( sender, args ) =>
               {
                  parentNode.Nodes.Clear();
                  AddRecipeResultsToNode( parentNode, recipeResults, rec );
                  parentNode.ExpandAll();
               } ) );
               toolTipText += string.Format( "{0} - {1}\n", index++, infos.GetSpecificItemNames() );
            }

            parentNode.ContextMenu = menu;
            parentNode.ToolTipText = toolTipText;
         }

         AddRecipeResultIngredients( parentNode, recipeResult );
         AddRecipeResultAgents( parentNode, recipeResult );
         ManifestTreeNodeThemes.Apply( parentNode );
         BuildManifest();
      }

      private void AddRecipeResultIngredients( TreeNode parent, RecipeResult recipeResult )
      {
         IEnumerable<IngredientSlotInfo> infos = Db.GetIngredientSlotsInfoForRecipeResult( recipeResult );
         foreach ( IngredientSlotInfo info in infos )
         {
            TreeNode child = parent.Nodes.Add( @"i. " + info.DisplayName );
            child.Tag = info;

            if ( info.IsSpecific )
            {
               AddRecipes( child, info.Items.First().ItemId, EntityTypes.Item );
            }
            else
            {
               string toolTipText = "you are tired, and you left off here.:\n\n";
               ContextMenu menu = new ContextMenu();
               int index = 1;
               foreach ( Item item in info.Items )
               {
                  menu.MenuItems.Add( item.Name, ( sender, args ) =>
                  {
                     info.SpecificItem = item;
                     child.Text = @"a. " + item.Name;
                     child.Nodes.Clear();
                     AddRecipes( child, item.ItemId, EntityTypes.Item );
                     child.ExpandAll();
                     BuildManifest();
                     ManifestTreeNodeThemes.Apply( child );
                  } );
                  toolTipText += string.Format( "{0} - {1}\n", index++, item.Name );
               }

               child.ContextMenu = menu;
               child.ToolTipText = toolTipText;
            }

            ManifestTreeNodeThemes.Apply( child );
         }
         ManifestTreeNodeThemes.Apply( parent );
         parent.ExpandAll();
      }

      private void AddRecipeResultAgents( TreeNode parent, RecipeResult recipeResult )
      {
         IEnumerable<AgentSlotInfo> infos = Db.GetAgentSlotInfosForRecipeResult( recipeResult );
         foreach ( AgentSlotInfo info in infos )
         {
            TreeNode child = parent.Nodes.Add( @"a. " + info.DisplayName );
            child.Tag = info;

            if ( info.IsSpecific )
            {
               AddRecipes( child, info.Items.First().ItemId, EntityTypes.Item );
            }
            else
            {
               string toolTipText = "Select individual agent:\n\n";
               ContextMenu menu = new ContextMenu();
               int index = 1;
               foreach ( Item item in info.Items )
               {
                  menu.MenuItems.Add( item.Name, ( sender, args ) =>
                     {
                        info.SpecificItem = item;
                        child.Text = @"a. " + item.Name;
                        child.Nodes.Clear();
                        AddRecipes( child, item.ItemId, EntityTypes.Item );
                        child.ExpandAll();
                        BuildManifest();
                        ManifestTreeNodeThemes.Apply( child );
                     } );
                  toolTipText += string.Format( "{0} - {1}\n", index++, item.Name );
               }

               child.ContextMenu = menu;
               child.ToolTipText = toolTipText;
            }

            ManifestTreeNodeThemes.Apply( child );
         }

         ManifestTreeNodeThemes.Apply( parent );
      }

      // ================================================================================
      private int buildCounter = 1;
      private void BuildManifest()
      {
         theListView.Items.Clear();

         ManifestBuilder manifest = new ManifestBuilder();
         GetNodeTags( theTreeView.Nodes[ 0 ], manifest );

         foreach ( KeyValuePair<long, int> pair in manifest.Items )
         {
            ListViewItem item = theListView.Items.Add( Db.GetItemName( pair.Key ) );
            item.SubItems.Add( pair.Value.ToString() );

         }

         foreach ( KeyValuePair<long, int> pair in manifest.Components )
         {
            ListViewItem item = theListView.Items.Add( Db.SelectCraftingComponentById( pair.Key ).Name );
            item.SubItems.Add( pair.Value.ToString() );
            item.BackColor = Color.LightPink;
         }
      }

      private void GetNodeTags( TreeNode parent, ManifestBuilder builder )
      {
         foreach ( TreeNode child in parent.Nodes )
         {
            GetNodeTags( child, builder );
         }

         if ( parent.Tag is RecipeSlotInfo )
         {
            RecipeSlotInfo info = parent.Tag as RecipeSlotInfo;
            builder.AddSlotInfo( info );
         }
      }

      protected class ManifestTreeNodeThemes
      {
         protected delegate void ApplyProc( TreeNode node );

         protected static IDictionary<Type, ApplyProc> ThemeApplications = new Dictionary<Type, ApplyProc>
            {
               { typeof(CraftableEntity),
                  node => node.BackColor = Properties.Settings.Default.IngredientCraftedBackColor },

               { typeof(IngredientSlotInfo),
                  node => node.BackColor = ( node.Tag as IngredientSlotInfo ).IsSpecific
                     ? Properties.Settings.Default.IngredientGatheredBackColor
                     : Properties.Settings.Default.IngredientCraftedBackColor},

               { typeof(AgentSlotInfo),
                  node => node.BackColor = ( node.Tag as AgentSlotInfo ).IsSpecific
                  ? Properties.Settings.Default.IngredientCraftedBackColor
                  : Properties.Settings.Default.AgentComponentBackColor },

               { typeof(Recipe),
                 node => node.BackColor = null == node.ContextMenu
                  ? Properties.Settings.Default.RecipeSingleBackColor
                  : Properties.Settings.Default.RecipeMultipleBackColor },
            };

         public static void Apply( TreeNode node )
         {
            if ( null == node || null == node.Tag )
               return;

            if ( !ThemeApplications.ContainsKey( node.Tag.GetType() ) )
               throw new InvalidOperationException( @"Unable to find node theme application strategy." );

            ThemeApplications[ node.Tag.GetType() ]( node );
         }
      }

      internal class CraftableEntity
      {
         public CraftableEntity( NamedEntity entity )
         {
            Entity = entity;
         }

         public NamedEntity Entity { get; private set; }
         public bool IsItem { get { return Entity is Item; } }
         public bool IsFitting { get { return Entity is Fitting; } }
         public bool IsBlueprint { get { return Entity is Blueprint; } }

         public long Id { get { return Entity.Id; } }
         public string Name { get { return Entity.Name; } }
         public EntityTypes EntityType
         {
            get { return IsItem ? EntityTypes.Item : IsFitting ? EntityTypes.Fitting : EntityTypes.Blueprint; }
         }
      }

      private void legendToggleButton_Click( object sender, EventArgs e )
      {
         // cheap toggle check
         if ( @"Hide" == legendToggleButton.Text )
         {
            legendToggleButton.Text = @"Show";
            legendPanel.Height = 27;
         }
         else
         {
            legendToggleButton.Text = @"Hide";
            legendPanel.Height = 138;
         }
      }
   }
}
