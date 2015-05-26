using System;

namespace RePopCraftingStudio.UserControls
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
}