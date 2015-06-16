using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using RePopCraftingStudio.Db;

namespace RePopCraftingStudio.UserControls
{
   public partial class ItemListSelection : OurUserControl
   {
      private delegate IEnumerable<Entity> SelectEntitiesByNameProc( string filter );

      private IDictionary<int, EntityListView> _listViews;
      private IDictionary<int, SelectEntitiesByNameProc> _selecters;
      private IDictionary<int, SelectEntitiesByNameProc> Selecters
      {
         get
         {
            if ( null == _selecters )
            {
               _selecters = new Dictionary<int, SelectEntitiesByNameProc>
                  {
                     {0, Db.SelectItemEntitiesByName},
                     {1, Db.SelectFittingEntitiessByName},
                     {2, Db.SelectBlueprintEntitiesByName},
                  };
            }

            return _selecters;
         }
      }

      public ItemListSelection()
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

      private void ItemListSelection_Load( object sender, EventArgs e )
      {
         _listViews = new Dictionary<int, EntityListView>
            {
               {0, itemsListView},
               {1, fittingsListView},
               {2, blueprintsListView},
            };

         itemsListView.EntityType = typeof( Item );
         fittingsListView.EntityType = typeof( Fitting );
         blueprintsListView.EntityType = typeof( Blueprint );
      }

      public override void LoadSettings()
      {
         selectionTabControl.SelectedIndex = Properties.Settings.Default.LastSelectionTabIndex;
         // NOTE: set this after user has chance to verify DB connection string
         searchTextBox.Text = Properties.Settings.Default.LastItemFilter;

         base.LoadSettings();
      }

      public override void SaveSettings()
      {
         base.SaveSettings();

         Properties.Settings.Default.LastSelectionTabIndex = selectionTabControl.SelectedIndex;
         Properties.Settings.Default.LastItemFilter = searchTextBox.Text;
      }

      private EntityListView ActiveListView { get { return _listViews[ selectionTabControl.SelectedIndex ]; } }
      private SelectEntitiesByNameProc ActiveSelecter { get { return Selecters[ selectionTabControl.SelectedIndex ]; } }
      private Entity SelectedEntity
      {
         get
         {
            if ( 0 == ActiveListView.SelectedItems.Count )
               return null;

            return (Entity)ActiveListView.SelectedItems[ 0 ].Tag;
         }
      }

      private void searchTextBox_TextChanged( object sender, EventArgs e )
      {
         UpdateSearch();
      }

      private void selectionTabControl_SelectedIndexChanged( object sender, EventArgs e )
      {
         UpdateSearch();
      }

      private void UpdateSearch()
      {
         ActiveListView.Fill( ActiveSelecter( searchTextBox.Text ) );
      }

      private void EntityListView_SelectedIndexChanged( object sender, EventArgs e )
      {
         OnEntitySelected( new EntitySelectedEventArgs( SelectedEntity ) );
      }
   }
}
