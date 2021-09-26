using System;

namespace GildedRoseKata.Inventory.Utilities.Special
{
    public static class Conjured
    {
        private static string Key => "Conjured";
        
        public static readonly Predicate<Item> AdjustmentMultiplier = 
            item => item.Name.StartsWith(Key);
    }
}