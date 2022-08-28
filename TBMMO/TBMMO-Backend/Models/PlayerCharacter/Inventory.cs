namespace TBMMO_Backend.Models.PlayerCharacter
{
    public class Inventory
    {
        public int Id { get; set; }
        public string PlayerCharacterName { get; set; }
        public virtual PlayerCharacter PlayerCharacter { get; set; }
        public virtual IEnumerable<Bag> Bags { get; set; }
    }
}
