using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Famille
    {
        [Key]
        public int Id_Famille { get; set; }
        [Required]
        public int Libellè { get; set; }

    }
}
