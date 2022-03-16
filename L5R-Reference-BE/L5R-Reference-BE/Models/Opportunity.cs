using MongoDB.Bson.Serialization.Attributes;

namespace L5R_Reference_BE.Models
{
    public class Opportunity
    {
        [BsonElement("effects")]
        public string Cost { get; set; }

        [BsonElement("effects")]
        public string Ability { get; set; }
    }
}
