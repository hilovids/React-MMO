namespace TBMMO_Backend.Models
{
    public class ProfessionSheet
    {
        public int Id { get; set; }
        public string PlayerCharacterId { get; set; }
        public virtual PlayerCharacter PlayerCharacter { get; set; }
        public virtual IEnumerable<PlayerProfession> Professions { get; set; }
    }
}
