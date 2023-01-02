using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Commande
    {
        [Key]
        public int Id_Commande { get; set; }
        [Required]
        public int Date { get; set; }
        [Required]
        public int Id_Utilisateur { get; set; }
        [Required]
        public  double Prix { get; set; }
        [Required]
        public string status { get; set;}

    }
}
