#nullable enable
namespace GildedRoseKata.Inventory
{
    public interface IItemQuality
    {
        public int? Quality { get; }
    }

    public interface IItemSellIn
    {
        
        public int? SellIn { get; }
    }
    
    public class ItemProps : IItemQuality, IItemSellIn
    {
        public int? Quality { get; init; }
        public int? SellIn { get; init; }
    }
}
