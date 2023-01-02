using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Ròle
    {
        [Key]
        public int Id_Role { get; set; }
        [Required]
        public int Libelle { get; set; }
    }
}
