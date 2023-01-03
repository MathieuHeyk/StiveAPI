using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Commande
    {
        [Key]
        public int Id_commande { get; set; }

        [Required]
        public int Date { get; set; }
        [Required]
        public int Id_utilisateur { get; set; }

        [Required]
        public  double Prix { get; set; }

        [Required]
        public string Status { get; set;}
    }
}
