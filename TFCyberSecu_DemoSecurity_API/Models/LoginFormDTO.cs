using System.ComponentModel.DataAnnotations;

namespace TFCyberSecu_DemoSecurity_API.Models
{
    public class LoginFormDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
