using System.ComponentModel.DataAnnotations;

namespace J30_API_SEGURO.Models
{
    public class Almacen
    {
        [Key]
        public int IdAlmacen { get; set; }
        [Required]
        public int IdAuto { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public int StockMinimo { get; set; }

    }       
}
