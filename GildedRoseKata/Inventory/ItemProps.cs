#nullable enable
namespace GildedRoseKata.Inventory
{
    public interface IItemName
    {
        public string? Name { get; }
    }
    
    public interface IItemQuality
    {
        public int? Quality { get; }
    }

    public interface IItemSellIn
    {
        
        public int? SellIn { get; }
    }
    
    public class ItemProps : IItemName, IItemQuality, IItemSellIn
    {
        public string? Name { get; init; }
        public int? Quality { get; init; }
        public int? SellIn { get; init; }
    }
}
