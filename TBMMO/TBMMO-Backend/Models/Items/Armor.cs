using TBMMO_Backend.Data;
using TBMMO_Backend.Models.PlayerCharacter;

namespace TBMMO_Backend.Models.Items
{
    // Example of how we could expand our classes from the interfaces we have
    public class Armor : Item
    {
        public int? ClothingId { get; set; }
        public virtual Clothing Clothing { get; set; }
        public string EquipText { get; set; }
    }
}
