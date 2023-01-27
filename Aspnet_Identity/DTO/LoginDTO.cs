using System.ComponentModel.DataAnnotations;

namespace Aspnet_Identity.DTO
{
    // Login DTO
    public class LoginDTO
    {
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
