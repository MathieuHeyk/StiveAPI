using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Commande
    {
        [Key]
        public int Num_commande { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public double Prix_Total { get; set; }

        [Required]
        public string Date { get; set; }
        
        [Required]
        public int Id_utilisateur { get; set; }

        
    }
}
