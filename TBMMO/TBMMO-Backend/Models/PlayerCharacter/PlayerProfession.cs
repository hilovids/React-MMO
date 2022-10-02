using TBMMO_Backend.Data;

namespace TBMMO_Backend.Models.PlayerCharacter
{
    public class PlayerProfession : ITrainable
    {
        public int Id { get; set; }
        public int ProfessionSheetId { get; set; }
        public virtual ProfessionSheet ProfessionSheet { get; set; }
        public int ProfessionId { get; set; }
        public virtual Profession Profession { get; set; }
        public int MaxValue
        {
            get
            {
                return Profession.MaxValue;
            }
        }
        public int Value { get; set; }
    }
}