using MongoDB.Bson.Serialization.Attributes;

namespace Customer.API.Entities
{
    public class CustomerEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
