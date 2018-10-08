using MongoDB.Bson;

namespace ecomm1.Models
{
    public class vare
    {
        public ObjectId _id { get; set; }
        public int VareId { get; set; }
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }
        public int Pris { get; set; }
        public bool Udsolgt { get; set; }

    }
}