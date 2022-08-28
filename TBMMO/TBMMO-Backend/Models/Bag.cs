namespace TBMMO_Backend.Models
{
    public class Bag
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public virtual Inventory Inventory { get; set; }
        public int Slots { get; set; }
        public virtual IEnumerable<Item> Items { get; set; }
    }
}