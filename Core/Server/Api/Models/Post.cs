using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BlogEngineApi.Models
{
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        [JsonProperty("name")]
        public string PostName { get; set; }
        [BsonElement("blog")]
        [JsonProperty("blog")]
        public string Blog { get; set; }
        [BsonElement("category")]
        public string Category { get; set; }
        [BsonElement("content")]
        public string Content { get; set; }
    }
}