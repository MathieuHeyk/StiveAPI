using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class LigneCommande
    {
        [Key]
        public int Id_ligne_commande { get; set; }

        [Required]
        public int Id_article { get; set; }

        [Required]
        public int  Quantite { get; set; }

        [Required]
        public int Numero_commande { get; set; }
    }
}
