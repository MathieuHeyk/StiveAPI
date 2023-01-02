using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Ligne_de_commande
    {
        [Key]
        public int Id_Ligne_de_Commande { get; set; }
        [Required]
        public int Id_Article { get; set; }
        [Required]
        public int  quantite { get; set; }
        [Required]
        public int Numero_de_Commande { get; set; }
    }
}
