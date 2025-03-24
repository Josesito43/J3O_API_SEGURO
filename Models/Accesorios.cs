using MongoDB.Bson.Serialization.Attributes;

namespace J30_API_SEGURO.Models
{
    public class Accesorios
    {
        [BsonElement("IdAccesorio")]
        public int IdAccesorio { get; set; }

        [BsonElement("Nombre")]
        public  string Nombre { get; set; }

        [BsonElement("Tipo")]
        public  string Tipo { get; set; }
    }
}
