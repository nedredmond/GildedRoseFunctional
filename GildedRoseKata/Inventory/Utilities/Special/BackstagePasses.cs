namespace GildedRoseKata.Inventory.Utilities.Special
{
    public static class BackstagePasses
    {
        public static string Key => "Backstage passes to a TAFKAL80ETC concert";

        public static Item Adjust(Item item) =>
            ItemUtils.Quality.Adjust(item, GetAdjustmentAmount(item));

        private static int GetAdjustmentAmount(Item item) => item.SellIn switch
        {
            <= 0 => -item.Quality,
            <= 5 => 3,
            <= 10 => 2,
            _ => 1
        };
    }
}