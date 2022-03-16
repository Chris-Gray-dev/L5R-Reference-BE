using MongoDB.Bson.Serialization.Attributes;

namespace L5R_Reference_BE.Models
{
    public class Source
    {
        [BsonElement("book")]
        public string Book { get; set; }

        [BsonElement("page")]
        public int Page { get; set; }
    }
}
