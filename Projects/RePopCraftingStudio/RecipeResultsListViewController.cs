using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using RePopCraftingStudio.Db;
using RePopCraftingStudio.UserControls;

namespace RePopCrafting
{
   [AttributeUsage( AttributeTargets.Property )]
   public class EntityColumnAttribute : Attribute
   {
      public EntityColumnAttribute( string displayName )
         : this( displayName, 60 )
      { }

      public EntityColumnAttribute( string displayName, int width )
      {
         DisplayName = displayName;
         Width = width;
      }

      public string DisplayName { get; set; }
      public int Width { get; set; }
   }

   internal class RecipeResultsListViewController : ControlController
   {
      private readonly EntityListView _view;

      public RecipeResultsListViewController( RepopDb db, EntityListView view )
         : base( db )
      {
         _view = view;
         _view.EntityType = typeof( RecipeResult );
      }

      public RecipeResult SelectedRecipeResult
      {
         get
         {
            if ( 0 == _view.SelectedItems.Count )
               return null;

            return _view.SelectedItems[ 0 ].Tag as RecipeResult;
         }
      }

      public void Clear()
      {
         _view.Items.Clear();
      }

      public void Fill( Recipe recipe )
      {
         _view.Fill( Db.SelectRecipeResultsForRecipe( recipe ).OfType<Entity>() );
      }
   }

   //ListViewItem item = _view.Items.Add( result.RecipeId.ToString() );
   //item.SubItems.Add( result.GroupId.ToString() );
   //item.SubItems.Add( result.Count.ToString() );
   //item.SubItems.Add( result.Grade.ToString() );
   //item.SubItems.Add( result.Level.ToString() );
   //item.SubItems.Add( result.Type.ToString() );
   //item.SubItems.Add( result.ResultId.ToString() );
   //item.SubItems.Add( result.Filter1Id.ToString() );
   //item.SubItems.Add( result.Filter2Id.ToString() );
   //item.SubItems.Add( result.Filter3Id.ToString() );
   //item.SubItems.Add( result.Filter4Id.ToString() );
}