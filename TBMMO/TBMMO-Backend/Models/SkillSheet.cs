namespace TBMMO_Backend.Models
{
    public class SkillSheet
    {
        public int Id { get; set; }
        public string PlayerCharacterId { get; set; }
        public virtual PlayerCharacter PlayerCharacter { get; set; }
        public virtual IEnumerable<PlayerSkill> Skills {get; set;}
    }
}
