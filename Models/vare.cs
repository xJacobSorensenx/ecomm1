using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ecomm1.Models
{
    public class vare
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string VareId { get; set; }
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }
        public int Pris { get; set; }
        public bool Udsolgt { get; set; }

    }
}