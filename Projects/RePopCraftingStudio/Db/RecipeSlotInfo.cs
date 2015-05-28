using System.Collections.Generic;
using System.Linq;

namespace RePopCraftingStudio.Db
{
   public abstract class RecipeSlotInfo
   {
      public IEnumerable<Item> Items { get; set; }
      public CraftingComponent Component { get; set; }

      public bool IsSpecific { get { return 1 == Items.Count(); } }
      public string DisplayName { get { return IsSpecific ? Items.First().Name : Component.Name; } }
      public Entity Entity { get { return IsSpecific ? (Entity)Items.First() : Component; } }
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