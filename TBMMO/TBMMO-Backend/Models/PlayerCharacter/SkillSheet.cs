namespace TBMMO_Backend.Models.PlayerCharacter
{
    public class SkillSheet
    {
        public int Id { get; set; }
        public string PlayerCharacterName { get; set; }
        public virtual PlayerCharacter PlayerCharacter { get; set; }
        public virtual IEnumerable<PlayerSkill> Skills { get; set; }
    }
}
