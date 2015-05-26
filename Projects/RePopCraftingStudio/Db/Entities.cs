using System;
using System.Diagnostics;
using System.Linq;
using RePopCrafting;
using RePopCraftingStudio.UserControls;

namespace RePopCraftingStudio.Db
{
   public enum EntityTypes : long
   {
      Item = 1,
      Fitting = 2,
      Blueprint = 3,
   }

   public abstract class Entity
   {
      protected RepopDb Db { get; private set; }
      protected object[] Items { get; private set; }

      protected Entity( RepopDb db, object[] items )
      {
         Db = db;
         Items = items;
      }

      public string WhatAmI { get { return GetType().ToString(); } }

      public override string ToString()
      {
         string format = string.Empty;
         for ( int i = 0; i < Items.Count(); i++ )
         {
            format += string.Format( @"{{{0}}}", i );
            if ( i != Items.Count() - 1 )
               format += @", ";
         }

         return string.Format( format, Items );
      }
   }

   public abstract class NamedEntity : Entity
   {
      protected NamedEntity( RepopDb db, object[] items )
         : base( db, items )
      {
      }

      public abstract long Id { get; }
      public abstract string Name { get; }
   }

   [DebuggerDisplay( @"{ItemId}: {Name}" )]
   public class Item : NamedEntity
   {
      public Item( RepopDb db, object[] items )
         : base( db, items )
      {
      }

      [EntityColumn( @"Item Id" )]
      public long ItemId { get { return (long)Items[ 0 ]; } }
      public override long Id { get { return ItemId; } }

      [EntityColumn( @"Name", 256 )]
      public override string Name { get { return (string)Items[ 1 ]; } }
      public string Description { get { return (string)Items[ 2 ]; } }
      public long IconId { get { return (long)Items[ 3 ]; } }

      public override string ToString() { return Name; }
   }

   [DebuggerDisplay( @"{FittingId}: {Name}" )]
   public class Fitting : NamedEntity
   {
      public Fitting( RepopDb db, object[] items )
         : base( db, items )
      {
      }

      [EntityColumn( @"Fitting Id" )]
      public long FittingId { get { return (long)Items[ 0 ]; } }
      public override long Id { get { return FittingId; } }

      [EntityColumn( @"Name", 256 )]
      public override string Name { get { return (string)Items[ 1 ]; } }
      public string Description { get { return (string)Items[ 2 ]; } }

      public override string ToString() { return Name; }
   }

   [DebuggerDisplay( @"{StructureId}: {Name}" )]
   public class Blueprint : NamedEntity
   {
      public Blueprint( RepopDb db, object[] items )
         : base( db, items )
      {
      }

      [EntityColumn( @"Structure Id" )]
      public long StructureId { get { return (long)Items[ 0 ]; } }
      public override long Id { get { return StructureId; } }

      [EntityColumn( @"Name", 256 )]
      public override string Name { get { return (string)Items[ 1 ]; } }

      [EntityColumn( @"Is Housing" )]
      public bool IsHousing { get { return 1 == (long)Items[ 2 ]; } }

      public override string ToString() { return Name; }
   }

   [DebuggerDisplay( @"{ComponentId}: {Name}" )]
   public class CraftingComponent : Entity
   {
      public CraftingComponent( RepopDb db, object[] items )
         : base( db, items )
      {
      }

      public long ComponentId { get { return (long)Items[ 0 ]; } }
      public string Name { get { return (string)Items[ 1 ]; } }
      public string Description { get { return (string)Items[ 2 ]; } }
      public long IconId { get { return (long)Items[ 3 ]; } }

      public override string ToString()
      {
         return Name;
      }
   }

   public class Recipe : Entity
   {
      public Recipe( RepopDb db, object[] items )
         : base( db, items )
      {
      }

      public long RecipeId { get { return (long)Items[ 0 ]; } }
      public string Name { get { return (string)Items[ 1 ]; } }
      public string Description { get { return (string)Items[ 2 ]; } }
      public long SkillId { get { return (long)Items[ 3 ]; } }
      //public string SkillName { get { return Db.GetSkillName( SkillId ); } }
      public string SkillName { get { return @"TODO: Fix SkillName getter"; } }
      public long Steps { get { return (long)Items[ 4 ]; } }
      public long IngredientWeight { get { return (long)Items[ 5 ]; } }
      public long AgentWeight { get { return (long)Items[ 6 ]; } }
   }

   public class RecipeAgent : Entity
   {
      public RecipeAgent( RepopDb db, object[] items )
         : base( db, items )
      {
      }

      public long RecipeId { get { return (long)Items[ 0 ]; } }
      public long ComponentId { get { return (long)Items[ 1 ]; } }
      public string ComponentName { get { return @"TODO: Fix ComponentName for RecipeAgent"; } }
      public long Count { get { return (long)Items[ 2 ]; } }
      public long Weight { get { return (long)Items[ 3 ]; } }
   }

   public class RecipeIngredient : Entity
   {
      public RecipeIngredient( RepopDb db, object[] items )
         : base( db, items )
      {
      }

      public long RecipeId { get { return (long)Items[ 0 ]; } }
      public long ComponentId { get { return (long)Items[ 1 ]; } }
      public string ComponentName { get { return @"TODO: Fix ComponentName for RecipeIngredient"; } }
      public long Count { get { return (long)Items[ 2 ]; } }
      public long Weight { get { return (long)Items[ 3 ]; } }
      public long IngSlot { get { return (long)Items[ 4 ]; } }
   }

   public class RecipeResult : Entity
   {
      public RecipeResult( RepopDb db, object[] items )
         : base( db, items )
      {
      }

      [EntityColumn( @"Recipe Id" )]
      public long RecipeId { get { return (long)Items[ 0 ]; } }

      [EntityColumn( @"Recipe Name", 96 )]
      //public string RecipeName { get { return Db.GetRecipeName( this ); } }
      public string RecipeName { get { return @"TODO: Fix RecipeName getter"; } }

      [EntityColumn( @"Group Id" )]
      public long GroupId { get { return (long)Items[ 1 ]; } }

      [EntityColumn( @"Count" )]
      public long Count { get { return (long)Items[ 2 ]; } }

      [EntityColumn( @"Grade" )]
      public long Grade { get { return (long)Items[ 3 ]; } }

      [EntityColumn( @"Level" )]
      public long Level { get { return (long)Items[ 4 ]; } }

      [EntityColumn( @"Type" )]
      public EntityTypes Type { get { return (EntityTypes)Items[ 5 ]; } }

      [EntityColumn( @"Result Id" )]
      public long ResultId { get { return (long)Items[ 6 ]; } }

      //[EntityColumn( @"Result Name", 96 )]
      //public string ResultName { get { return Db.GetItemName( ResultId ); } }

      [EntityColumn( @"Filter 1 Id" )]
      public long Filter1Id { get { return (long)Items[ 7 ]; } }

      //[EntityColumn( @"Filter 1 Name", 96 )]
      //public string Filter1Name { get { return Db.GetCraftingFilterName( Filter1Id ); } }

      [EntityColumn( @"Filter 2 Id" )]
      public long Filter2Id { get { return (long)Items[ 8 ]; } }

      //[EntityColumn( @"Filter 2 Name", 96 )]
      //public string Filter2Name { get { return Db.GetCraftingFilterName( Filter2Id ); } }

      [EntityColumn( @"Filter 3 Id" )]
      public long Filter3Id { get { return (long)Items[ 9 ]; } }

      //[EntityColumn( @"Filter 3 Name", 96 )]
      //public string Filter3Name { get { return Db.GetCraftingFilterName( Filter3Id ); } }

      [EntityColumn( @"Filter 4 Id" )]
      public long Filter4Id { get { return (long)Items[ 10 ]; } }

      //[EntityColumn( @"Filter 4 Name", 96 )]
      //public string Filter4Name { get { return Db.GetCraftingFilterName( Filter4Id ); } }

      public long GetFilterId( int index )
      {
         if ( index < 1 || index > 4 )
            throw new ArgumentOutOfRangeException( @"index in GetFilterId is out of range." );

         return (long)Items[ 6 + index ];
      }
   }
}