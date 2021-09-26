using System.Linq;

namespace GildedRoseKata.Inventory.Utilities
{
    public static partial class ItemUtils
    {
        public static partial class Quality
        {
            public static Item Adjust(Item item, int amount) =>
                item.Clone(new ItemProps
                {
                    Quality = item.Quality + amount * GetAdjustmentMultiplier(item)
                });

            public static Item Adjust(Item item) =>
                Adjust(item, -1);

            private static int GetAdjustmentMultiplier(Item item) =>
                Rules.Quality.AdjustmentMultipliers
                    .Where(f => f(item))
                    .Aggregate(1, (current, _) => current * 2);
        }
    }
}