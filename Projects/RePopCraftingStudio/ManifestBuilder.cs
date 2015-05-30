using System.Collections.Generic;
using System.Linq;
using RePopCraftingStudio.Db;

namespace RePopCraftingStudio
{
   public class ManifestBuilder
   {
      public ManifestBuilder()
      {
         Components = new Dictionary<long, int>();
         Items = new Dictionary<long, int>();
      }

      public int SlotCount { get; private set; }
      public IDictionary<long, int> Components { get; private set; }
      public IDictionary<long, int> Items { get; private set; }

      public void AddSlotInfo( RecipeSlotInfo info )
      {
         SlotCount++;
         if ( info.IsSpecific )
         {
            if ( !Items.ContainsKey( info.SpecificItem.ItemId ) )
               Items[ info.SpecificItem.ItemId ] = 0;
            Items[ info.SpecificItem.ItemId ]++;
         }
         else
         {
            if ( !Components.ContainsKey( info.Component.ComponentId ) )
               Components[ info.Component.ComponentId ] = 0;
            Components[ info.Component.ComponentId ]++;
         }
      }
   }
}