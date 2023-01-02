using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Utilisateur
    {
        [Key]
        public int Id_Utilisateur { get; set; }
        [Required]
        public string Nom_de_Famille { get; set; }
        [Required]
        public int Prenome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Mot_de_Passe { get; set; }
        [Required]
        public int Telephone { get; set; }
        [Required]
        public int Id_Lieu { get; set;}
        [Required]
        public string Id_Ròle { get; set;}
    }
}
