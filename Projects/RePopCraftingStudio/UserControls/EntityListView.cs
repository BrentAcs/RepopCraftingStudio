using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using RePopCrafting;
using RePopCraftingStudio.Db;

namespace RePopCraftingStudio.UserControls
{
   public partial class EntityListView : ListView
   {
      private Type _entityType;

      public EntityListView()
      {
         InitializeComponent();

         FullRowSelect = true;
         View = View.Details;
         HideSelection = false;
         MultiSelect = false;

         AlternateLineItemColor = Color.LightCyan;
      }

      public Color AlternateLineItemColor { get; set; }

      public Type EntityType
      {
         get { return _entityType; }
         set { _entityType = value; InitializeColumns(); }
      }

      public void Fill( IEnumerable<Entity> entities )
      {
         Items.Clear();

         Color backColor = AlternateLineItemColor;
         foreach ( Entity entity in entities )
         {
            ListViewItem item = null;

            backColor = (BackColor == backColor) ? AlternateLineItemColor : BackColor;

            foreach ( ColumnHeader header in Columns )
            {
               PropertyInfo propInfo = GetPropertyInfo( entity.GetType(), header.Text );
               string value = propInfo.GetValue( entity, null ).ToString();
               if ( null == item )
               {
                  item = Items.Add( value );
               }
               else
               {
                  item.SubItems.Add( value );
               }
            }

            item.BackColor = backColor;
            item.Tag = entity;
         }
      }

      private void InitializeColumns()
      {
         if ( null == EntityType )
            return;

         foreach ( PropertyInfo propInfo in EntityType.GetProperties() )
         {
            EntityColumnAttribute attr = propInfo.GetCustomAttributes( typeof( EntityColumnAttribute ), true ).FirstOrDefault() as EntityColumnAttribute;
            if ( null == attr )
               continue;

            Columns.Add( attr.DisplayName, attr.Width );
         }
      }

      private PropertyInfo GetPropertyInfo( Type type, string name )
      {
         return type.GetProperties()
            .FirstOrDefault( p => p.GetCustomAttributes( true ).OfType<EntityColumnAttribute>()
               .Any( a => 0 == string.Compare( a.DisplayName, name, StringComparison.OrdinalIgnoreCase ) ) );
      }
   }
}
