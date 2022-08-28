using TBMMO_Backend.Data;

namespace TBMMO_Backend.Models.Items
{
    // Example of how we could expand our classes from the interfaces we have
    public class Armor : Item, IWearable
    {
        public int? ClothingId { get; set; }
        public string EquipText { get; set; }
    }
}
