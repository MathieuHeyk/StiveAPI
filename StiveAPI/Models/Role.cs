using System.ComponentModel.DataAnnotations;

namespace StiveAPI.Models
{
	public class Role
	{
		[Key]
		public int Id_role { get; set; }

		[Required]
		public string Libelle { get; set; }
	}
}
