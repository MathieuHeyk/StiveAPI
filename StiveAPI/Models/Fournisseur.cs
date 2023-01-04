using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Fournisseur
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }
        
        [Required]
        public string Telephone { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        public int Id_lieu { get; set; }

    }
}