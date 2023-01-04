using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Lieu
    {
        [Key]
        public int Id_lieu { get; set; }

        [Required]
        public string Numero { get; set; }
        
        [Required]
        public string Type { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Ville { get; set; }

        [Required]
        public string Code_postal { get; set; }

        [Required]
        public string Pays { get; set; }    
    }

}
