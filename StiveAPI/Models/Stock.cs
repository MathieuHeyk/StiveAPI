using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
	public class Stock
	{
		[Key]
		public int Id_stock { get; set; }

		[Required]
		public int Id_article { get; set; }

		[Required]
		public int Quantite { get; set; }
	}
}
