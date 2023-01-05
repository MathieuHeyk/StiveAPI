using Microsoft.AspNetCore.Mvc;
using StiveAPI.Helpers;
using StiveAPI.Models;

namespace StiveAPI.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class LieuController
	{
		[HttpPost(Name ="AddLieu")]
		public void AddLieu(string numero, string type, string nom, string ville, string code_postal, string pays)
		{
			using StiveController context = new();

			Lieu lieu = new();
			lieu.Numero = numero;
			lieu.Type = type;
			lieu.Nom = nom;
			lieu.Ville = ville;
			lieu.Code_postal = code_postal;
			lieu.Pays = pays;

			context.Add(lieu);
			context.SaveChanges();
		}

		[HttpPut(Name ="EditLieu")]
		public void EditLieu(int id, string numero, string type, string nom, string ville, string code_postal, string pays)
		{
			using StiveController context = new();

			Lieu lieu = context.Lieux.Where(l => l.Id_lieu == id).First();
			lieu.Numero = numero;
			lieu.Type = type;
			lieu.Nom = nom;
			lieu.Ville = ville;
			lieu.Code_postal = code_postal;
			lieu.Pays = pays;

			context.Update(lieu);
			context.SaveChanges();
		}

		[HttpDelete]
		public void DeleteLieu(int id)
		{
			using StiveController context = new();

			Lieu lieu = context.Lieux.Where(l => l.Id_lieu == id).First();
			
			context.Remove(lieu);
			context.SaveChanges();
		}

		[HttpGet(Name ="GetAllLieux")]
		public List<Lieu> GetAllLieux()
		{
			using StiveController context = new();

			List<Lieu> lieux = context.Lieux.ToList();
			return lieux;
		}

		[HttpGet(Name ="GetLieuById")]
		public Lieu GetLieuById(int id)
		{
			using StiveController context = new();

			Lieu lieu = context.Lieux.Where(l => l.Id_lieu == id).First();
			return lieu;
		}
	}
}
