using System;
using RePopCraftingStudio.Db;

namespace RePopCraftingStudio.UserControls
{
   public class EntitySelectedEventArgs : EventArgs
   {
      public Entity Entity { get; private set; }

      public EntitySelectedEventArgs( Entity entity )
      {
         Entity = entity;
      }
   }
}