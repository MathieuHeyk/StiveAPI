using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Lieu
    {
        [Key]
        public int Id_lieu { get; set; }

        [Required]
        public string Numero { get; set; }

        public string Type { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public int Ville { get; set;}

        [Required]
        public int Code_postal { get; set;}

        [Required]
        public int Pays { get; set;}
    }
}
