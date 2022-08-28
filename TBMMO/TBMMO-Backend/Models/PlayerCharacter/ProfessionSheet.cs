namespace TBMMO_Backend.Models.PlayerCharacter
{
    public class ProfessionSheet
    {
        public int Id { get; set; }
        public string PlayerCharacterName { get; set; }
        public virtual PlayerCharacter PlayerCharacter { get; set; }
        public virtual IEnumerable<PlayerProfession> Professions { get; set; }
    }
}
