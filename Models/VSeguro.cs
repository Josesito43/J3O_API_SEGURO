using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Bson.Serialization.Attributes;

namespace J30_API_SEGURO.Models
{
    public class VSeguro
    {
        [BsonElement("Contratado")]
        public bool Contratado { get; set; }


        [BsonElement("PagosSeguro")]
        public List<Pagos> PagosSeguro { get; set; } = new List<Pagos>();
    }
}
