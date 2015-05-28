using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RePopCrafting;
using RePopCraftingStudio.Db;

namespace RePopCraftingStudio
{
   public partial class MainForm : Form
   {
      private RepopDb _db;

      //private RecipeTreeViewController _recipeTreeViewController;
      //private RecipeResultsListViewController _recipeResultsListViewController;

      public MainForm()
      {
         InitializeComponent();
      }

      private void Form1_Load( object sender, EventArgs e )
      {
         _db = new RepopDb( this );
         theItemListSelection.Db = _db;
         theManifestCreater.Db = _db;

         //_recipeTreeViewController = new RecipeTreeViewController( _db, recipeTreeView );
         //_recipeResultsListViewController = new RecipeResultsListViewController( _db, recipeResultsListView );

         LoadSettings();


         //_db.SchemaTest();
         //ItemManifest distWater = _db.BuildManifest( 290 );  // distilled water
         //ItemManifest sulfAcid = _db.BuildManifest( 974 );  // sulfuric acid
         //ItemManifest getSetlang = _db.BuildManifest( 442 ); // genetically engineered setlang
      }

      private void Form1_FormClosing( object sender, FormClosingEventArgs e )
      {
         SaveSettings();
      }

      private void theItemListSelection_EntitySelected( object sender, UserControls.EntitySelectedEventArgs e )
      {
         SetDebugEntity(e.Entity);
         theManifestCreater.RootEntity = e.Entity;
      }

      private void theManifestCreater_EntitySelected( object sender, UserControls.EntitySelectedEventArgs e )
      {
         SetDebugEntity( e.Entity );
      }

      private void itemFilterTextBox_TextChanged( object sender, EventArgs e )
      {
         //FillItemsListBox( itemFilterTextBox.Text );
      }

      private void itemsListBox_SelectedIndexChanged( object sender, EventArgs e )
      {
         //thePropertyGrid.SelectedObject = itemsListBox.SelectedItem;

         //Item item = (Item)itemsListBox.SelectedItem;
         //_recipeResultsListViewController.Clear();
         //_recipeTreeViewController.Fill( _db.SelectRecipesForItem( item ) );

         //FillManifiestTreeView( _db.BuildManifest( item.ItemId ) );
      }

      private void itemFilterTextBox_KeyUp( object sender, KeyEventArgs e )
      {
         //if ( e.KeyCode == Keys.Down )
         //{
         //   itemsListBox.SelectedIndex = 0;
         //   itemsListBox.Focus();
         //}
      }

      private void recipeTreeView_AfterSelect( object sender, TreeViewEventArgs e )
      {
         //if ( null == e.Node )
         //{
         //   thePropertyGrid.SelectedObject = null;
         //   return;
         //}

         //thePropertyGrid.SelectedObject = e.Node.Tag;

         //if ( e.Node.Tag is Recipe )
         //{
         //   //_recipeResultsListViewController.Fill( e.Node.Tag as Recipe );
         //}
      }

      private void manifestTreeView_AfterSelect( object sender, TreeViewEventArgs e )
      {
         //if ( null == e.Node )
         //{
         //   thePropertyGrid.SelectedObject = null;
         //   return;
         //}

         //thePropertyGrid.SelectedObject = e.Node.Tag;
      }

      private void recipeResultsListView_SelectedIndexChanged( object sender, EventArgs e )
      {
         //thePropertyGrid.SelectedObject = _recipeResultsListViewController.SelectedRecipeResult;
      }

      private void SetDebugEntity( Entity entity )
      {
         thePropertyGrid.SelectedObject = entity;
      }

      private void FillItemsListBox( string filter )
      {
         //itemsListBox.Items.Clear();
         //IEnumerable<Item> items = _db.SelectItemsByName( filter );
         //foreach ( Item item in items )
         //{
         //   itemsListBox.Items.Add( item );
         //}
      }

      private void LoadSettings()
      {
         _db.ConnectionString = Properties.Settings.Default.ConnectionString;
         TestDbConnection();

         Location = Properties.Settings.Default.MainLocation;
         Size = Properties.Settings.Default.MainSize;
         mainSplitContainer.SplitterDistance = Properties.Settings.Default.MainSplitterDistance;
         leftSplitContainer.SplitterDistance = Properties.Settings.Default.LeftSplitterDistance;
         gameViewSplitContainer.SplitterDistance = Properties.Settings.Default.GameViewSplitterDistance;
         //manifestViewSplitContainer.SplitterDistance = Properties.Settings.Default.ManifestViewSplitterDistance;
         theTabControl.SelectedIndex = Properties.Settings.Default.LastTabIndex;

         theItemListSelection.LoadSettings();
         theManifestCreater.LoadSettings();
      }

      private void SaveSettings()
      {
         Properties.Settings.Default.MainLocation = Location;
         Properties.Settings.Default.MainSize = Size;
         Properties.Settings.Default.MainSplitterDistance = mainSplitContainer.SplitterDistance;
         Properties.Settings.Default.LeftSplitterDistance = leftSplitContainer.SplitterDistance;
         Properties.Settings.Default.GameViewSplitterDistance = gameViewSplitContainer.SplitterDistance;
         //Properties.Settings.Default.ManifestViewSplitterDistance = manifestViewSplitContainer.SplitterDistance;
         Properties.Settings.Default.LastTabIndex = theTabControl.SelectedIndex;
         Properties.Settings.Default.ConnectionString = _db.ConnectionString;

         theItemListSelection.SaveSettings();
         theManifestCreater.SaveSettings();

         Properties.Settings.Default.Save();
      }

      private void TestDbConnection()
      {
         try
         {
            // test db connection
            _db.GetItemName( 1 );
         }
         catch ( Exception ex )
         {
            OpenFileDialog dialog = new OpenFileDialog
            {
               Title = @"Select The Repopulation database file.",
               Multiselect = false,
               CheckFileExists = true,
               FileName = @"repopdata.db3",
            };
            if ( DialogResult.OK == dialog.ShowDialog( this ) )
            {
               _db.ConnectionString = string.Format( "Data Source=\"{0}\"", dialog.FileName );
            }
         }
      }

      //private void FillManifiestTreeView( ItemManifest itemManifest )
      //{
      //   manifestTreeView.Nodes.Clear();

      //   if ( null == itemManifest )
      //   {
      //      manifestTreeView.Nodes.Add( @"no manifest available." );
      //      return;
      //   }

      //   TreeNode node = manifestTreeView.Nodes.Add( itemManifest.Item.Name );
      //   AddManifestNode( node, itemManifest );

      //   node.ExpandAll();


      //   manifestTextBox.Text = string.Empty;
      //   IDictionary<string, long> manifest = new Dictionary<string, long>( StringComparer.OrdinalIgnoreCase );
      //   AddToManifest( node, manifest );

      //   StringBuilder builder = new StringBuilder();
      //   foreach ( string key in manifest.Keys )
      //   {
      //      builder.AppendFormat( @"{0}: {1}", key, manifest[ key ] );
      //      builder.AppendLine();
      //   }
      //   manifestTextBox.Text = builder.ToString();

      //   string more = manifestTextBox.Text.Replace( "\r\n", ", " );
      //   manifestTextBox.Text += "\r\n\r\n" + more;
      //}

      //private void AddToManifest( TreeNode parent, IDictionary<string, long> manifest )
      //{
      //   foreach ( TreeNode child in parent.Nodes )
      //   {
      //      if ( 0 == child.Nodes.Count )
      //      {
      //         ItemManifest.Entry entry = (ItemManifest.Entry)child.Tag;
      //         if ( entry.IsSpecific )
      //         {
      //            if ( !manifest.ContainsKey( entry.SpecificItem.Name ) )
      //               manifest[ entry.SpecificItem.Name ] = 0;
      //            manifest[ entry.SpecificItem.Name ]++;
      //         }
      //         else
      //         {
      //            if ( !manifest.ContainsKey( entry.Component.Name ) )
      //               manifest[ entry.Component.Name ] = 0;
      //            manifest[ entry.Component.Name ]++;
      //         }
      //      }
      //      else
      //      {
      //         AddToManifest( child, manifest );
      //      }
      //   }

      //}

      //private void AddManifestNode( TreeNode parent, ItemManifest itemManifest )
      //{
      //   if ( null == itemManifest )
      //   {
      //      return;
      //   }

      //   foreach ( ItemManifest.Entry ingredient in itemManifest.Ingredients )
      //   {
      //      TreeNode node = parent.Nodes.Add( ingredient.IsSpecific ? ingredient.SpecificItem.Name : ingredient.Component.Name );
      //      node.Tag = ingredient;
      //      if ( ingredient.IsSpecific )
      //      {
      //         AddManifestNode( node, _db.BuildManifest( ingredient.SpecificItem.ItemId ) );
      //      }
      //   }

      //   foreach ( ItemManifest.Entry agent in itemManifest.Agents )
      //   {
      //      TreeNode node = parent.Nodes.Add( agent.Component.Name );
      //      node.Tag = agent;
      //      AddManifestNode( node, _db.BuildManifest( agent.SpecificItem.ItemId ) );
      //   }
      //}
   }
}
