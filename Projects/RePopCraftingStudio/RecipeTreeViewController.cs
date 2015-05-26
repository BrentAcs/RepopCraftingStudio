using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RePopCraftingStudio.Db;

namespace RePopCrafting
{
   //internal abstract class ControlController
   //{
   //   protected RepopDb Db { get; private set; }

   //   protected ControlController( RepopDb db )
   //   {
   //      Db = db;
   //   }
   //}

   //internal class RecipeTreeViewController : ControlController
   //{
   //   private readonly TreeView _view;

   //   public RecipeTreeViewController( RepopDb db, TreeView view )
   //      : base( db )
   //   {
   //      _view = view;
   //   }

   //   public void Fill( IEnumerable<Recipe> recipes )
   //   {
   //      _view.Nodes.Clear();

   //      foreach ( Recipe recipe in recipes )
   //      {
   //         TreeNode node = _view.Nodes.Add( recipe.Name );
   //         node.Tag = recipe;
   //         node.BackColor = Color.LightBlue;
   //         //node.NodeFont = new Font( _view.Font.FontFamily, _view.Font.Size, FontStyle.Bold );
   //         AddRecipe( node, recipe );
   //      }

   //      _view.ExpandAll();
   //   }

   //   private void AddRecipe( TreeNode parent, Recipe recipe )
   //   {
   //      AddIngredients( parent, recipe );
   //      AddAgents(parent, recipe);
   //   }

   //   private void AddIngredients( TreeNode parent, Recipe recipe )
   //   {
   //      //TreeNode baseNode = parent.Nodes.Add( @"Ingredients" );
   //      //foreach ( RecipeIngredient ingredient in Db.SelectRecipeIngredientsForRecipe( recipe ) )
   //      //{
   //      //   TreeNode node = baseNode.Nodes.Add( ingredient.ComponentName );
   //      //   node.Tag = ingredient;
   //      //}
   //   }

   //   private void AddAgents( TreeNode parent, Recipe recipe )
   //   {
   //      //TreeNode baseNode = parent.Nodes.Add( @"Agents" );
   //      //foreach ( RecipeAgent agent in Db.SelectRecipeAgentsForRecipe( recipe ) )
   //      //{
   //      //   TreeNode node = baseNode.Nodes.Add( agent.ComponentName );
   //      //   node.Tag = agent;
   //      //}
   //   }
   //}
}