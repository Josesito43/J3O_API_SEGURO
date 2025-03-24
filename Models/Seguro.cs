using System.ComponentModel.DataAnnotations;

namespace J30_API_SEGURO.Models
{
    public class Seguro
    {
        [Key]
        public int IdSeguro { get; set; }

        [Required]
        public string Tipo { get; set;}
        [Required]
        public decimal Costo { get; set; }
    
        [Required]  
        public string Proveedor { get; set;}
        [Required]

        public int Duracion { get; set;}   
    }
}
