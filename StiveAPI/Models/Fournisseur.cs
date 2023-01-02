using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Fournisseur
    {
        [Key]
        public int Id_Fournisseur{ get; set; }
        [Required]

        public int Id_Lieu { get; set; }
        [Required]
        public int Societe { get; set; }
        [Required]
        public int Email { get; set; }
        [Required]
        public int Telhone_Fixe { get; set; }


    }
}
