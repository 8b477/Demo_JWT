using System.ComponentModel.DataAnnotations;

namespace TFCyberSecu_DemoSecurity_API.Models
{
    public class AddArticle
    {
        [Required]
        public string Nom { get; set; }

        [Required]
        [Range(0,2500)]
        public int Prix { get; set; }


        public string Categorie { get; set; }
        public string Description { get; set; }
    }
}
