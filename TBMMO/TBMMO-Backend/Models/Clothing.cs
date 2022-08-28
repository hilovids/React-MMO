using TBMMO_Backend.Data;

namespace TBMMO_Backend.Models
{
    public class Clothing
    {
        public int Id  { get; set; }
        public string PlayerCharacterName { get; set; }
        public virtual IEnumerable<IWearable> EquippedItems { get; set; }
    }
}
