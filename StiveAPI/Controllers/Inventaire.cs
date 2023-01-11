using Microsoft.AspNetCore.Mvc;
using StiveAPI.Helpers;
using StiveAPI.Models;


namespace StiveAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class InventaireController
    {
        [HttpPost(Name = "AddInventaire")]
        public void AddInventaire(int id_article, int quantite, string date, int id_utilisateur)
        {
            using StiveController context = new();
            Inventaire inventaire = new Inventaire();
            inventaire.Id_article = id_article;
            inventaire.Quantite = quantite;
            inventaire.Date = date;
            inventaire.Id_utilisateur = id_utilisateur;

            context.Add(inventaire);
            context.SaveChanges();

        }
        [HttpPost(Name = "EditInventaire")]
        public void EditInventaire(int id, int id_article, int quantite, string date, int id_utilisateur)
        {
            using StiveController context = new();

            Inventaire inventaire = context.Inventaires.Where(a => a.Id_article == id).First();
            inventaire.Id_article = id_article;
            inventaire.Quantite = quantite;
            inventaire.Date = date;
            inventaire.Id_utilisateur = id_utilisateur;

            context.Update(inventaire);
            context.SaveChanges();
        }
        [HttpDelete(Name = "GettAllnventaire")]
        public List<Inventaire> GetAllInventaires()
        {
            using StiveController context = new();


            List<Inventaire> inventaires = context.Inventaires.ToList();
            return inventaires;

        }
        [HttpGet(Name = "GetInventaireById")]
        public Inventaire GetInventaireById(int id)
        {
            using StiveController context = new();

            Inventaire inventaire = context.Inventaires.Where(a => a.Id_inventaire == id).First();

            List<Inventaire> inventaires = context.Inventaires.ToList();
            return inventaire;
        }
        [HttpDelete(Name = "DeleteInventaire")]
        public void DeleteInventaire(int id)
        {
            using StiveController context = new();

            Inventaire inventaire = context.Inventaires.Where(a => a.Id_inventaire == id).First();


            context.Remove(inventaire);
            context.SaveChanges();
        }
    }
}