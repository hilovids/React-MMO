using TBMMO_Backend.Models;

namespace TBMMO_Backend.Data
{
    public interface IWearable
    {
        public int? ClothingId { get; set; }
        public string EquipText { get; set; }
    }
}