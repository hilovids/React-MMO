namespace TBMMO_Backend.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string PlayerCharacterId { get; set; }
        public virtual PlayerCharacter PlayerCharacter { get; set; }
        public virtual IEnumerable<Bag> Bags { get; set; }
    }
}
