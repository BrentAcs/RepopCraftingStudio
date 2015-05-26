using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using RePopCraftingStudio.Db;
using RePopCraftingStudio.UserControls;

namespace RePopCrafting
{
   //internal class RecipeResultsListViewController : ControlController
   //{
   //   private readonly EntityListView _view;

   //   public RecipeResultsListViewController( RepopDb db, EntityListView view )
   //      : base( db )
   //   {
   //      _view = view;
   //      _view.EntityType = typeof( RecipeResult );
   //   }

   //   public RecipeResult SelectedRecipeResult
   //   {
   //      get
   //      {
   //         if ( 0 == _view.SelectedItems.Count )
   //            return null;

   //         return _view.SelectedItems[ 0 ].Tag as RecipeResult;
   //      }
   //   }

   //   public void Clear()
   //   {
   //      _view.Items.Clear();
   //   }

   //   public void Fill( Recipe recipe )
   //   {
   //      //_view.Fill( Db.SelectRecipeResultsForRecipe( recipe ).OfType<Entity>() );
   //   }
   //}
}