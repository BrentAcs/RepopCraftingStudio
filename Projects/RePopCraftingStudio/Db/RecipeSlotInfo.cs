using System.Collections.Generic;
using System.Linq;

namespace RePopCraftingStudio.Db
{
   public abstract class RecipeSlotInfo
   {
      private Item _specificItem;

      public IEnumerable<Item> Items { get; set; }
      public CraftingComponent Component { get; set; }

      public Item SpecificItem
      {
         get { return _specificItem ?? Items.First(); }
         set { _specificItem = value; }
      }

      public bool IsSpecific { get { return ( null != _specificItem ) || ( 1 == Items.Count() ); } }

      public string DisplayName { get { return IsSpecific ? SpecificItem.Name : Component.Name; } }

      public Entity Entity { get { return IsSpecific ? (Entity)SpecificItem : Component; } }
   }

   public class AgentSlotInfo : RecipeSlotInfo
   {
   }

   public class IngredientSlotInfo : RecipeSlotInfo
   {
      public int IngSlot { get; set; }
   }

   public static class IngredientSlotInfoExtensions
   {
      public static string GetSpecificItemNames( this IEnumerable<IngredientSlotInfo> infos )
      {
         string names = string.Empty;
         foreach ( IngredientSlotInfo info in infos )
         {
            if ( info.IsSpecific )
               names += info.Items.First().Name + @", ";
         }
         if ( string.IsNullOrEmpty( names ) )
            names = @"Nothing specific";

         return names;
      }
   }
}