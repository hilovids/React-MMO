using TBMMO_Backend.Data;

namespace TBMMO_Backend.Models.Items
{
    public class Food : Item, ICookable
    {
        public string CookText { get; set; }
    }
}
