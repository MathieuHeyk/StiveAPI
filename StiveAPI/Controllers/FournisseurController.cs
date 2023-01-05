using Microsoft.AspNetCore.Mvc;
using StiveAPI.Helpers;
using StiveAPI.Models;

namespace StiveAPI.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class FournisseurController
	{
		[HttpPost(Name ="AddFournisseur")]
		public void AddFournisseur(string nom, string telephone, string email, int id_lieu)
		{
			using StiveController context = new();

			Fournisseur fournisseur = new();
			fournisseur.Nom = nom;
			fournisseur.Telephone = telephone;
			fournisseur.Email = email;
			fournisseur.Id_lieu = id_lieu;

			context.Add(fournisseur);
			context.SaveChanges();
		}

		[HttpPut(Name ="EditFournisseur")]
		public void EditFournisseur(int id, string nom, string telephone, string email, int id_lieu)
		{
			using StiveController context = new();

			Fournisseur fournisseur = context.Fournisseurs.Where(f => f.Id == id).First();
			fournisseur.Nom = nom;
			fournisseur.Telephone = telephone;
			fournisseur.Email = email;
			fournisseur.Id_lieu = id_lieu;

			context.Update(fournisseur);
			context.SaveChanges();
		}

		[HttpDelete(Name ="DeleteFournisseur")]
		public void DeleteFournisseur(int id)
		{
			using StiveController context = new();

			Fournisseur fournisseur = context.Fournisseurs.Where(f => f.Id == id).First();

			context.Remove(fournisseur);
			context.SaveChanges();
		}

		[HttpGet(Name ="GetAllFournisseurs")]
		public List<Fournisseur> GetAllFournisseurs()
		{
			using StiveController context = new();

			List<Fournisseur> fournisseurs = context.Fournisseurs.ToList();
			return fournisseurs;
		}

		[HttpGet(Name ="GetFournisseurById")]
		public Fournisseur GetFournisseurById(int id)
		{
			using StiveController context = new();

			Fournisseur fournisseur = context.Fournisseurs.Where(f => f.Id == id).First();
			return fournisseur;
		}
	}
}
