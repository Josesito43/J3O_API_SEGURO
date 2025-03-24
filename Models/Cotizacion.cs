using System.ComponentModel.DataAnnotations;

namespace J30_API_SEGURO.Models
{
    public class Cotizacion
    {
        [Key]
        public int IdCotizacion { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int IdCliente { get; set; }

        [Required]
        public int IdSeguro { get; set; }

        [Required]
        public int IdAuto { get; set; }

        [Required]
        public decimal CostoTotal { get; set; }


  
    }
}
