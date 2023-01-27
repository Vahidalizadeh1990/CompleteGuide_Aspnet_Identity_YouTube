using System.ComponentModel.DataAnnotations;

namespace Aspnet_Identity.DTO
{
    // ResetPassword DTO
    public class ResetPasswordDTO
    {
        [Compare("ConfirmPassword",ErrorMessage ="Password does not match")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
