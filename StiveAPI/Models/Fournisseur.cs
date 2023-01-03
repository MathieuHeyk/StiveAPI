using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Fournisseur
    {
        [Key]
        public int Id_fournisseur { get; set; }
        
        [Required]
        public int Id_lieu { get; set; }
        
        [Required]
        public int Societe { get; set; }
        
        [Required]
        public int Email { get; set; }
        
        [Required]
        public int Telephone { get; set; }
    }
}
