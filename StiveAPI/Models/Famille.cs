using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Famille
    {
        [Key]
        public int Id_famille { get; set; }

        [Required]
        public int Libellè { get; set; }
    }
}
