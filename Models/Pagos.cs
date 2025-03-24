using MongoDB.Bson.Serialization.Attributes;

namespace J30_API_SEGURO.Models
{
    public class Pagos
    {
        [BsonElement("Fecha")]
        public DateTime Fecha { get; set; }

        [BsonElement("Monto")]
        public decimal Monto { get; set; }

        [BsonElement("Metodo")]
        public string Metodo { get; set; }
    }
}
