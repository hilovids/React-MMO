namespace TBMMO_Backend.Models.PlayerCharacter
{
    public class StatSheet
    {
        public int Id { get; set; }
        public string PlayerCharacterName { get; set; }
        public virtual PlayerCharacter PlayerCharacter { get; set; }
        public int HP { get; set; }
    }
}
