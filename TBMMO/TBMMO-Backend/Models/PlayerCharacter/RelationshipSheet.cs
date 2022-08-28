namespace TBMMO_Backend.Models.PlayerCharacter
{
    public class RelationshipSheet
    {
        public int Id { get; set; }
        public string PlayerCharacterName { get; set; }
        public virtual PlayerCharacter PlayerCharacter { get; set; }
        public virtual IEnumerable<PlayerRelationship> Relationships { get; set; }
    }
}
