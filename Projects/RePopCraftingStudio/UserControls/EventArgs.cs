using System;
using RePopCraftingStudio.Db;

namespace RePopCraftingStudio.UserControls
{
   public class ObjectSelectedEventArgs : EventArgs
   {
      public object Object { get; private set; }

      public ObjectSelectedEventArgs( object obj )
      {
         Object = obj;
      }
   }

   public class EntitySelectedEventArgs : EventArgs
   {
      public Entity Entity { get; private set; }

      public EntitySelectedEventArgs( Entity entity )
      {
         Entity = entity;
      }
   }
}