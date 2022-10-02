namespace TBMMO_Backend.Models.Items
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? BagId { get; set; }
        public virtual Bag? Bag { get; set; }
    }
}