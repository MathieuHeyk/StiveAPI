using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Stock
    {
        [Key]
        public int Id_stock { get; set; }
        
        [Required]
        public int Article { get; set; }
        
        [Required]
        public string Quantite { get; set; }
    }
}
