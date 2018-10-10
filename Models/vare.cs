using System.ComponentModel.DataAnnotations;
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
        [Required]
        public int Pris { get; set; }
        [Required]
        public bool Udsolgt { get; set; }

    }
}