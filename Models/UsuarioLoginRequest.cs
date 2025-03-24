using Microsoft.AspNetCore.Mvc;

namespace J30_API_SEGURO.Models
{
   
    public class UsuarioLoginRequest
    {
        public required string email  { get; set; }
        public required string password { get; set; }
    }
}
