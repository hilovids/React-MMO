using TBMMO_Backend.Data;

namespace TBMMO_Backend.Models.PlayerCharacter
{
    public class PlayerSkill : ITrainable
    {
        public int Id { get; set; }
        // One to One relationship with a player's skillsheet and a particular skill
        public int SkillSheetId { get; set; }
        public virtual SkillSheet SkillSheet { get; set; }
        public int SkillId { get; set; }
        public virtual Skill Skill { get; set; }
        // the player's skill value is held on the joining class through the 'ITrainable' interface
        public int MaxValue
        {
            get
            {
                return Skill.MaxValue;
            }
        }
        public int Value { get; set; }
    }
}