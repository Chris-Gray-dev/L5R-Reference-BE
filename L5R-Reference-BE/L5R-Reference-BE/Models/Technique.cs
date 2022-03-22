using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Newtonsoft.Json;
using L5R_Reference_BE.Enums;

namespace L5R_Reference_BE.Models
{
    public class Technique
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("type")]
        public TechniqueType Type { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("rank")]
        public int Rank { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("activation")]
        public string Activation { get; set; }

        [BsonElement("source")]
        public Source? Source { get; set; }

        [BsonElement("clan")]
        public string? Clan { get; set; }

        [BsonElement("effects")]
        public string? Effects { get; set; }

        // Todo turn to list of opportunities
        [BsonElement("newOpportunities")]
        public List<Opportunity>? NewOpportunities { get; set; }

        [BsonElement("enhancementEffect")]
        public string? EnhancementEffect { get; set; }

        [BsonElement("burstEffect")]
        public string? BurstEffect { get; set; }

        [BsonElement("ring")]
        public Ring? Ring { get; set; }

        [BsonElement("style")]
        public KataStyle? Style { get; set; }
    }
}
