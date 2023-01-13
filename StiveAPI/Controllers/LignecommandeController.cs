using Microsoft.AspNetCore.Mvc;
using StiveAPI.Helpers;
using StiveAPI.Models;

namespace StiveAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LigneCommandeController
    {
        [HttpPost(Name = "AddLigneCommande")]
        public void AddLignecommande(int Id_article, int Quantite, int num_commande)
        {
            using StiveController context = new();

            LigneCommande ligneCommande = new();
            ligneCommande.Id_article = Id_article;
            ligneCommande.Quantite = Quantite;
            ligneCommande.Num_commande = num_commande;

            context.Add(ligneCommande);
            context.SaveChanges();
        }

        [HttpPut(Name = "EditLigneCommande")]
        public void EditLignecommande(int id, int Id_article, int Quantite, int num_commande)
        {
            using StiveController context = new();

            LigneCommande ligneCommande = context.LigneCommandes.Where(l => l.Id_ligne_commande == id).First();
            ligneCommande.Id_article = Id_article;
            ligneCommande.Quantite = Quantite;
            ligneCommande.Num_commande = num_commande;

            context.Update(ligneCommande);
            context.SaveChanges();
        }

        [HttpDelete(Name = "DeleteLigneCommande")]
        public void DeleteLignecommande(int id)
        {
            using StiveController context = new();

            LigneCommande ligneCommande = context.LigneCommandes.Where(l => l.Id_ligne_commande == id).First();
            ligneCommande.Id_ligne_commande = id;

            context.Remove(ligneCommande);
            context.SaveChanges();
        }

        [HttpGet(Name = "GetAllLigneCommande")]
        public List<LigneCommande> GetAllLigneCommande()
        {
            using StiveController context = new();

            List<LigneCommande> ligneCommandes = context.LigneCommandes.ToList();
            return ligneCommandes;
        }

        [HttpGet(Name = "GetLigneCommandeById")]
        public LigneCommande GetLigneCommandeById(int id)
        {
            using StiveController context = new();

            LigneCommande ligneCommande = context.LigneCommandes.Where(f => f.Id_ligne_commande == id).First();
            return ligneCommande;
        }
    }
}
