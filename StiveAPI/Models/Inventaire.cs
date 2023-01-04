using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Inventaire
    {
        [Key]
        public int Id_inventaire { get; set; }

        [Required]
        public int Id_article{ get; set; }

        [Required]
        public int Quantite { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public int Id_utilisateur { get; set; }
    }
}
