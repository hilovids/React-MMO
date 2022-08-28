using TBMMO_Backend.Data;

namespace TBMMO_Backend.Models.PlayerCharacter
{
    public class PlayerRelationship : ITrainable
    {
        public int Id { get; set; }
        public int RelationshipSheetId { get; set; }
        public virtual RelationshipSheet RelationshipSheet { get; set; }
        // unfinished. need a way to store a relationship to either location, organization, or NPC. Initial thought was to use an interface but on further inspection that might not work
        // AN option is to use an enum to specify the type of relationship, and then go about it as normal. But that might not be good from the NPC/Location/Org side of things. 
        // Another option is more objects, but idk quite how I feel about that. 
        // I will add this to the trello
        public RelationshipType RelationshipType { get; set; }
        public string RecipientName { get; set; } // represents name of NPC, Location, or Organization
        public int MaxValue
        {
            get
            {
                return 1000;
            }
        }
        public int Value { get; set; }
    }

    public enum RelationshipType
    {
        NPC,
        Location,
        Organization
    }
}