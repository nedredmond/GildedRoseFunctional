using System;
using System.Collections.Generic;
using GildedRoseKata.Inventory.Utilities.Special;

namespace GildedRoseKata.Inventory.Utilities
{
    public static partial class Rules
    {
        public static class Quality
        {
            public static readonly List<Predicate<Item>> AdjustmentMultipliers = new()
            {
                item => item.SellIn <= 0,
                Conjured.AdjustmentMultiplier
            };

            public static readonly Dictionary<string, Func<Item, Item>> AdjustmentRules = new()
                {
                    {Sulfuras.Key, Sulfuras.TheOneRuleOfRagnaros},
                    {BackstagePasses.Key, BackstagePasses.Adjust},
                    {AgedBrie.Key, AgedBrie.Adjust}
                }
            ;
            
            public static readonly Dictionary<string, Func<Item,Item>> ConstraintRules = new()
            {
                {Sulfuras.Key, Sulfuras.TheOneRuleOfRagnaros}
            };

            public enum Constraints
            {
                Lower = 0,
                Upper = 50
            }
        }
    }
}