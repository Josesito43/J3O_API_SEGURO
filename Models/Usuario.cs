using System.ComponentModel.DataAnnotations;
namespace J30_API_SEGURO.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required, EmailAddress]
        public string Correo { get; set; }
        [Required]
        public string Contrasenia { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string CURP { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        public string Tipo { get; set; }    

    }
}
