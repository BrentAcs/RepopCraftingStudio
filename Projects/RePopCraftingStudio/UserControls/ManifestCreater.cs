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

         base.LoadSettings();
      }

      public override void SaveSettings()
      {
         base.SaveSettings();

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
         Debug.Assert( recipes.Any() );
         if ( !recipes.Any() )
            return;

         AddRecipeToNode( entityNode, recipes, recipes.First() );
      }

      private void AddRecipeToNode( TreeNode parentNode, IEnumerable<Recipe> recipes, Recipe recipe )
      {
         TreeNode child = parentNode.Nodes.Add( recipe.Name );
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
                  AddRecipeToNode( parentNode, recipes, rec );
               } ) );
               toolTipText += string.Format( "{0} - {1}\n", index++, rec.Name );
            }

            child.BackColor = Color.LightSkyBlue;

            child.ContextMenu = menu;
            child.ToolTipText = toolTipText;
         }

         AddRecipeResults( child );
      }

      private void AddRecipeResults( TreeNode recipeNode )
      {
         Recipe recipe = (Recipe)recipeNode.Tag;
         IEnumerable<RecipeResult> recipeResults = Db.SelectRecipeResultsForRecipeAndResult( recipe.RecipeId, _rootEntity.Id );
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
            child.Text += @" - " + Db.GetIngredientSlotInfoForRecipeResults( recipeResult ).GetSpecificItemNames();

            string toolTipText = "Potential Result Combos:\n\n";
            ContextMenu menu = new ContextMenu();
            int index = 1;
            foreach ( RecipeResult rec in recipeResults )
            {
               IEnumerable<IngredientSlotInfo> infos = Db.GetIngredientSlotInfoForRecipeResults( rec );
               menu.MenuItems.Add( new MenuItem( infos.GetSpecificItemNames(), ( sender, args ) =>
               {
                  parentNode.Nodes.Clear();
                  AddRecipeResultsToNode( parentNode, recipeResults, rec );
               } ) );
               toolTipText += string.Format( "{0} - {1}\n", index++, infos.GetSpecificItemNames() );
            }

            child.BackColor = Color.LightSkyBlue;

            child.ContextMenu = menu;
            child.ToolTipText = toolTipText;
         }

         AddRecipeResultIngredients(child, recipeResult);
      }

      private void AddRecipeResultIngredients(TreeNode parent, RecipeResult recipeResult)
      {
         IEnumerable<IngredientSlotInfo> infos = Db.GetIngredientSlotInfoForRecipeResults( recipeResult );
         foreach (IngredientSlotInfo info in infos)
         {
            TreeNode child = parent.Nodes.Add( @"i. " + info.DisplayName);
            child.Tag = info;

            // this is where the fun begins ...
            //if (info.IsSpecific)
            //{
            //   AddRecipes( child, info.Items.First().ItemId, EntityTypes.Item);
            //}

         }
         parent.ExpandAll();
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
}
