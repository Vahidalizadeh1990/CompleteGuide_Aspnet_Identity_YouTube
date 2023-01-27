using System.ComponentModel.DataAnnotations;

namespace Aspnet_Identity.DTO
{
    // Register DTO
    public class RegisterDTO
    {
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
