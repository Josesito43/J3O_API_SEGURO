using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace J30_API_SEGURO.Models
{
    public class Ventas
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdV { get; set; }

        [BsonElement("IdAuto")]
        public string IdAuto { get; set; }

        [BsonElement("IdUsuario")]
        public int IdUsuario { get; set; }

        [BsonElement("VentaAuto")]
        public List<VAuto> venta_auto { get; set; } = new List<VAuto>();

        [BsonElement("Seguro")]
        public List<VSeguro> Seguro { get; set; } = new List<VSeguro>();
    }
}
