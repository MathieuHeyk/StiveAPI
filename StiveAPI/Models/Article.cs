using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
	public class Article
	{
		[ Key ]
		public int Id { get; set; }

		[Required]
		public string Nom { get; set; }

		[Required]
		public double Prix_unitaire { get; set; }
		[Required]
		public double Prix_carton { get; set; }
		[Required]
		public int Annee { get; set; }
		[Required]
		public int ID_famille { get; set; }
		[Required]
		public int ID_fournisseur { get; set; }
	}
}
