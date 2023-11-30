using System.ComponentModel.DataAnnotations;

namespace TFCyberSecu_DemoSecurity_API.Models
{
    public class RegisterFormDTO
    {
        [Required]
        public string Nickname { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password Manquant")]
        [DataType(DataType.Password)]
        public string Pwd { get; set; }
    }
}
