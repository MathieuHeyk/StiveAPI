using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
    public class Stock
    {
        [Key]
        public int Id_Stock { get; set; }
        [Required] 
        public int Article { get; set; }
        [Required] 
        public string quantite { get; set; }
    }
}
