using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace M220N.Models
{
    public class User
    {
        [BsonElement("_id")]
        [JsonProperty("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [JsonProperty("auth_token")]
        [BsonIgnore]
        public string AuthToken { get; set; }

        public string Name { get; set; }

        [BsonElement("email")]
        [JsonProperty("email")]
        public string Email { get; set; }

        public string Password { get; set; }

        [JsonIgnore]
        public string HashedPassword { get; set; }

        public bool IsAdmin { get; set; }

        [BsonElement("preferences")]
        [JsonProperty("preferences ")]
        public Dictionary<string, string> Preferences { get; set; }
    }
}
