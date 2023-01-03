using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Utilisateur
    {
        [Key]
        public int Id_utilisateur { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public int Prenom { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public int Telephone { get; set; }

        [Required]
        public int Id_lieu { get; set;}

        [Required]
        public string Id_role { get; set;}
    }
}
