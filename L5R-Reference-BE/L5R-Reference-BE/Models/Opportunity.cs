using L5R_Reference_BE.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace L5R_Reference_BE.Models
{
    public class Opportunity
    {
        [BsonElement("costType")]
        public Ring CostType { get; set; }

        [BsonElement("costAmount")]
        public int? CostAmount { get; set; }

        [BsonElement("costMulti")]
        public bool? CostMulti { get; set; }

        [BsonElement("ability")]
        public string? Ability { get; set; }
    }
}
