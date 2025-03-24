using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Bson.Serialization.Attributes;

namespace J30_API_SEGURO.Models
{
    public class VAuto
    {
        [BsonElement("PrecioTotal")]
        public decimal PrecioTotal { get; set; }

        [BsonElement("TipoPago")]
        public string TipoPago { get; set; }

        [BsonElement("SaldoPendiente")]
        public decimal saldo_pendiente { get; set; }

        [BsonElement("PagosAuto")]
        public List<Pagos> PagosAuto { get; set; } = new List<Pagos>();
    }
}
