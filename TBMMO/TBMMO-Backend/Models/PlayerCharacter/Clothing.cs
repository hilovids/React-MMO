using TBMMO_Backend.Data;
using TBMMO_Backend.Models.Items;

namespace TBMMO_Backend.Models.PlayerCharacter
{
    public class Clothing
    {
        public int Id { get; set; }
        public string PlayerCharacterName { get; set; }
        public virtual IEnumerable<Armor> EquippedItems { get; set; }
    }
}
