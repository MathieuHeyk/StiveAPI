using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Inventaire
    {
        [Key]
        public int Id_Inventaire { get; set; }
        [Required]
        public int Quantite { get; set; }
        [Required]
        public int Date { get; set; }
        [Required]
        public int Id_Utilisateur { get; set; }
    }
}
