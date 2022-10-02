using System.ComponentModel.DataAnnotations;

namespace TBMMO_Backend.Models
{
    public class Location
    {
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<PlayerCharacter.PlayerCharacter> Players { get; set; }
    }
}
