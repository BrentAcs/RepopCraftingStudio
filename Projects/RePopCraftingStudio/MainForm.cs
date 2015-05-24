using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using RePopCrafting;
using RePopCraftingStudio.Db;

namespace RePopCraftingStudio
{
   public partial class MainForm : Form
   {
      private RepopDb _db;

      private RecipeTreeViewController _recipeTreeViewController;
      private RecipeResultsListViewController _recipeResultsListViewController;

      public MainForm()
      {
         InitializeComponent();
      }

      private void Form1_Load( object sender, EventArgs e )
      {
         //_db = new RepopDb( @"Data Source=C:\dev\RePopCrafting\db\repopdata.db3" );
         _db = new RepopDb();
         _recipeTreeViewController = new RecipeTreeViewController( _db, recipeTreeView );
         _recipeResultsListViewController = new RecipeResultsListViewController( _db, recipeResultsListView );

         LoadSettings();

         //_db.SchemaTest();
         _db.BuildManifest( 290 );  // distilled water
         _db.BuildManifest( 974 );  // sulfuric acid
      }

      private void Form1_FormClosing( object sender, FormClosingEventArgs e )
      {
         SaveSettings();
      }

      private void itemFilterTextBox_TextChanged( object sender, EventArgs e )
      {
         FillItemsListBox( itemFilterTextBox.Text );
      }

      private void itemsListBox_SelectedIndexChanged( object sender, EventArgs e )
      {
         thePropertyGrid.SelectedObject = itemsListBox.SelectedItem;

         Item item = (Item)itemsListBox.SelectedItem;
         _recipeResultsListViewController.Clear();
         _recipeTreeViewController.Fill( _db.SelectRecipesForItem( item ) );


         _db.BuildManifest( item.ItemId );
      }

      private void itemFilterTextBox_KeyUp( object sender, KeyEventArgs e )
      {
         if ( e.KeyCode == Keys.Down )
         {
            itemsListBox.SelectedIndex = 0;
            itemsListBox.Focus();
         }
      }

      private void recipeTreeView_AfterSelect( object sender, TreeViewEventArgs e )
      {
         if ( null == e.Node )
         {
            thePropertyGrid.SelectedObject = null;
            return;
         }

         thePropertyGrid.SelectedObject = e.Node.Tag;

         if ( e.Node.Tag is Recipe )
         {
            _recipeResultsListViewController.Fill( e.Node.Tag as Recipe );
         }
      }

      private void recipeResultsListView_SelectedIndexChanged( object sender, EventArgs e )
      {
         thePropertyGrid.SelectedObject = _recipeResultsListViewController.SelectedRecipeResult;
      }

      private void FillItemsListBox( string filter )
      {
         itemsListBox.Items.Clear();
         IEnumerable<Item> items = _db.SelectItemsByName( filter );
         foreach ( Item item in items )
         {
            itemsListBox.Items.Add( item );
         }
      }

      private void LoadSettings()
      {
         Location = Properties.Settings.Default.MainLocation;
         Size = Properties.Settings.Default.MainSize;
         mainSplitContainer.SplitterDistance = Properties.Settings.Default.MainSplitterDistance;
         leftSplitContainer.SplitterDistance = Properties.Settings.Default.LeftSplitterDistance;
         gameViewSplitContainer.SplitterDistance = Properties.Settings.Default.GameViewSplitterDistance;
         theTabControl.SelectedIndex = Properties.Settings.Default.LastTabIndex;
         _db.ConnectionString = Properties.Settings.Default.ConnectionString;

         try
         {
            // test db connection
            _db.GetItemName(1);
         }
         catch (Exception ex)
         {
            OpenFileDialog dialog = new OpenFileDialog
            {
               Title = @"Select The Repopulation database file.",
               Multiselect = false,
               CheckFileExists = true,
               FileName = @"repopdata.db3",
               //Filter = @"repopdata.db3",
            };
            if ( DialogResult.OK == dialog.ShowDialog( this ) )
            {
               _db.ConnectionString = string.Format( "Data Source=\"{0}\"", dialog.FileName );
            }
         }

         // NOTE: set this after user has chance to verify DB connection string
         itemFilterTextBox.Text = Properties.Settings.Default.LastItemFilter;
      }

      private void SaveSettings()
      {
         Properties.Settings.Default.MainLocation = Location;
         Properties.Settings.Default.MainSize = Size;
         Properties.Settings.Default.MainSplitterDistance = mainSplitContainer.SplitterDistance;
         Properties.Settings.Default.LeftSplitterDistance = leftSplitContainer.SplitterDistance;
         Properties.Settings.Default.GameViewSplitterDistance = gameViewSplitContainer.SplitterDistance;
         Properties.Settings.Default.LastItemFilter = itemFilterTextBox.Text;
         Properties.Settings.Default.LastTabIndex = theTabControl.SelectedIndex;
         Properties.Settings.Default.ConnectionString = _db.ConnectionString;

         Properties.Settings.Default.Save();
      }
   }
}
