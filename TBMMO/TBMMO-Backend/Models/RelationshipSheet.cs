namespace TBMMO_Backend.Models
{
    public class RelationshipSheet
    {
        public int Id { get; set; }
        public string PlayerCharacterId { get; set; }
        public virtual PlayerCharacter PlayerCharacter { get; set; }
        public virtual IEnumerable<PlayerRelationship> Relationships { get; set; }
    }
}
