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

      public event EventHandler<EntitySelectedEventArgs> EntitySelected;

      protected virtual void OnEntitySelected( EntitySelectedEventArgs e )
      {
         EventHandler<EntitySelectedEventArgs> handler = EntitySelected;
         if ( handler != null )
            handler( this, e );
      }

      public override void LoadSettings()
      {
         manifestSplitContainer.SplitterDistance = Properties.Settings.Default.ManifestViewSplitterDistance;

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
         if ( null == e.Node )
         {
            OnEntitySelected( new EntitySelectedEventArgs( null ) );
         }

         if ( e.Node.Tag is CraftableEntity )
         {
            OnEntitySelected( new EntitySelectedEventArgs( ( (CraftableEntity)e.Node.Tag ).Entity ) );
         }
         else if ( e.Node.Tag is IngredientSlotInfo )
         {
            OnEntitySelected( new EntitySelectedEventArgs( ( (IngredientSlotInfo)e.Node.Tag ).Entity ) );
         }
         else
         {
            OnEntitySelected( new EntitySelectedEventArgs( (Entity)e.Node.Tag ) );
         }
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
         //Debug.Assert( recipes.Any() );
         if ( !recipes.Any() )
            return;

         AddRecipeToNode( entityNode, recipes, recipes.First(), entityId );
      }

      private void AddRecipeToNode( TreeNode parentNode, IEnumerable<Recipe> recipes, Recipe recipe, long entityId )
      {
         TreeNode child = parentNode.Nodes.Add( @"Recipe: " + recipe.Name );
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
                  //BuildManifest();
               } ) );
               toolTipText += string.Format( "{0} - {1}\n", index++, rec.Name );
            }

            child.BackColor = Color.LightSkyBlue;

            child.ContextMenu = menu;
            child.ToolTipText = toolTipText;
         }

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
         TreeNode child = parentNode.Nodes.Add( @"Result" );
         child.Tag = recipeResult;

         if ( recipeResults.Count() > 1 )
         {
            child.Text += @" - " + Db.GetIngredientSlotsInfoForRecipeResult( recipeResult ).GetSpecificItemNames();

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

            child.BackColor = Color.LightSkyBlue;

            child.ContextMenu = menu;
            child.ToolTipText = toolTipText;
         }

         AddRecipeResultIngredients( child );
         AddRecipeResultAgents( child );
         //BuildManifest();
      }

      private void AddRecipeResultIngredients( TreeNode parent )
      {
         RecipeResult recipeResult = (RecipeResult)parent.Tag;
         IEnumerable<IngredientSlotInfo> infos = Db.GetIngredientSlotsInfoForRecipeResult( recipeResult );
         foreach ( IngredientSlotInfo info in infos )
         {
            TreeNode child = parent.Nodes.Add( @"i. " + info.DisplayName );
            child.Tag = info;

            // this is where the fun begins ...
            if ( info.IsSpecific )
            {
               child.BackColor = Color.LightGreen;
               AddRecipes( child, info.Items.First().ItemId, EntityTypes.Item );
            }
            else
            {
               child.BackColor = Color.LightPink;

               // TEST CODE
               //AddRecipes( child, info.Items.First().ItemId, EntityTypes.Item );
            }

         }
         parent.ExpandAll();
      }

      private void AddRecipeResultAgents( TreeNode parent )
      {
         RecipeResult recipeResult = (RecipeResult)parent.Tag;
         IEnumerable<AgentSlotInfo> infos = Db.GetAgentSlotInfosForRecipeResult( recipeResult );
         foreach ( AgentSlotInfo info in infos )
         {
            TreeNode child = parent.Nodes.Add( @"a. " + info.DisplayName );
            child.Tag = info;

            // this is where the fun begins ...
            if ( info.IsSpecific )
            {
               child.BackColor = Color.LightGreen;
               AddRecipes( child, info.Items.First().ItemId, EntityTypes.Item );
            }
            else
            {
               child.BackColor = Color.LightPink;
            }
         }
      }


      // ================================================================================
      private int buildCounter = 1;
      private void BuildManifest()
      {
         manifestTextBox.Text = string.Format( "Manifest build # {0} for {1}\r\n", buildCounter++, theTreeView.Nodes[ 0 ].Text );

         //List<object> stuffs = new List<object>();
         ManifestBuilder manifest = new ManifestBuilder();
         GetNodeTags( theTreeView.Nodes[ 0 ], manifest );

         StringBuilder builder = new StringBuilder();
         builder.AppendLine( "Items:" );
         foreach ( KeyValuePair<long, int> pair in manifest.Items )
         {
            builder.AppendFormat( "{0}: {1}\r\n", Db.GetItemName( pair.Key ), pair.Value );
         }

         builder.AppendLine( "\r\nComponents:" );
         foreach ( KeyValuePair<long, int> pair in manifest.Components )
         {
            builder.AppendFormat( "{0}: {1}\r\n", Db.SelectCraftingComponentById( pair.Key ).Name, pair.Value );
         }

         manifestTextBox.Text += builder.ToString();
      }

      private void GetNodeTags( TreeNode parent, ManifestBuilder builder )
      {
         foreach ( TreeNode child in parent.Nodes )
         {
            GetNodeTags( child, builder );
         }

         if ( parent.Tag is SlotInfo )
         {
            SlotInfo info = parent.Tag as SlotInfo;
            builder.AddSlotInfo( info );
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
   }

   public class ManifestBuilder
   {
      public ManifestBuilder()
      {
         Components = new Dictionary<long, int>();
         Items = new Dictionary<long, int>();
      }

      public int SlotCount { get; private set; }
      public IDictionary<long, int> Components { get; private set; }
      public IDictionary<long, int> Items { get; private set; }

      public void AddSlotInfo( SlotInfo info )
      {
         SlotCount++;
         if ( info.IsSpecific )
         {
            if ( !Items.ContainsKey( info.Items.First().ItemId ) )
               Items[ info.Items.First().ItemId ] = 0;
            Items[ info.Items.First().ItemId ]++;
         }
         else
         {
            if ( !Components.ContainsKey( info.Component.ComponentId ) )
               Components[ info.Component.ComponentId ] = 0;
            Components[ info.Component.ComponentId ]++;
         }
      }
   }
}
