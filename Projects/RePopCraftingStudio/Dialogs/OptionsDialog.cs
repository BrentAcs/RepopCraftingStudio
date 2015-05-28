using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RePopCraftingStudio.Dialogs
{
   public partial class OptionsDialog : Form
   {
      public OptionsDialog()
      {
         InitializeComponent();
      }

      private void OptionsDialog_Load( object sender, EventArgs e )
      {
         Color prop1 = GetProperty( @"Ingredient-Gathered-Color", Color.Yellow );
         Color prop2 = GetProperty( @"Ingredient-Gathered-Color", Color.Yellow );

         //theColorDialog.ShowDialog(this);
      }

      private void OptionsDialog_FormClosing( object sender, FormClosingEventArgs e )
      {
         if ( DialogResult.OK != DialogResult )
            return;
      }

      private T GetProperty<T>( string name, T defaultValue )
      {
         //

         SettingsProperty property = Properties.Settings.Default.Properties[ name ];
         if ( null == property )
         {
            property = new SettingsProperty( name )
               {
                  PropertyType = typeof( T ),
                  DefaultValue = defaultValue,
                  IsReadOnly = false,
                  Provider = Properties.Settings.Default.Providers["LocalFileSettingsProvider"],
               };
            property.Attributes.Add( typeof( UserScopedSettingAttribute ), new UserScopedSettingAttribute() );
            Properties.Settings.Default.Properties.Add( property );
            Properties.Settings.Default.Reload();
         }

         return (T) Properties.Settings.Default[name];
      }
   }
}
