using System.ComponentModel.DataAnnotations;

namespace TBMMO_Backend.Models.PlayerCharacter
{
    public class PlayerCharacter
    {
        // use the name of our character as a primary key, to ensure that no one logs into another player's account like in pokemon showdown
        [Key]
        // hash names and keys when entering them into the database
        public string Name { get; set; }
        public string? Password { get; set; }
        public string Salt { get; set; }
        public virtual SkillSheet Skills { get; set; }
        public virtual ProfessionSheet Professions { get; set; }
        public virtual RelationshipSheet Relationships { get; set; }
        public virtual StatSheet Stats { get; set; }
        public virtual Clothing Clothing { get; set; }
        public virtual Inventory Inventory { get; set; }
        public string LocationName { get; set; }
    }
}
