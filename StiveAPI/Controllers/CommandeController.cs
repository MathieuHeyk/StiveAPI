using Microsoft.AspNetCore.Mvc;
using StiveAPI.Helpers;
using StiveAPI.Models;

namespace StiveAPI.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class CommandeController
	{
		[HttpPost(Name ="AddCommand")]
		public void AddCommand(string status, double prix_total, string date, int id_utilisateur)
		{
			using StiveController context = new();

			Commande commande = new();
			commande.Status = status;
			commande.Prix_Total = prix_total;
			commande.Date = date;
			commande.Id_utilisateur = id_utilisateur;

			context.Add(commande);
			context.SaveChanges();
		}

		[HttpPut(Name ="EditCommand")]
		public void EditCommand(int id, string status, double prix_total, string date, int id_utilisateur)
		{
			using StiveController context = new();

			Commande commande = context.Commandes.Where(c => c.Num_commande == id).First();
			commande.Status = status;
			commande.Prix_Total = prix_total;
			commande.Date = date;
			commande.Id_utilisateur = id_utilisateur;

			context.Update(commande);
			context.SaveChanges();
		}

		[HttpDelete(Name ="DeleteCommand")]
		public void DeleteCommand(int id)
		{
			using StiveController context = new();

			Commande commande = context.Commandes.Where(c => c.Num_commande == id).First();
			
			context.Remove(commande);
			context.SaveChanges();
		}

		[HttpGet(Name ="GetAllCommands")]
		public List<Commande> GetAllCommands()
		{
			using StiveController context = new();

			List<Commande> commandes = context.Commandes.ToList();
			return commandes;
		}

		[HttpGet(Name ="GetCommandById")]
		public Commande GetCommandeById(int id)
		{
			using StiveController context = new();

			Commande commande = context.Commandes.Where(c => c.Num_commande == id).First();
			return commande;
		}
	}
}
