using Microsoft.AspNetCore.Mvc;
using StiveAPI.Helpers;
using StiveAPI.Models;

namespace StiveAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UtilisateurController
    {
        [HttpPost(Name = "AddUtilisateur")]
        public void AddUtilisateur(string Nom, string Prenom, string Email, string Password, string Telephone, int Id_role, int Id_lieu)
        {
            using StiveController context = new();
            Utilisateur utilisateur = new();

            utilisateur.Nom=Nom;
            utilisateur.Prenom=Prenom;
            utilisateur.Email=Email;
            utilisateur.Password=Password;
            utilisateur.Telephone=Telephone;
            utilisateur.Id_role=Id_role;
            utilisateur.Id_lieu=Id_lieu;
         
            context.Add(utilisateur);
            context.SaveChanges();
        }

        [HttpPut(Name = "EditUtilisateur")]
        public void EditUtilisateur(int id, string Nom, string Prenom, string Email, string Password, string Telephone, int Id_lieu, int Id_role)
        {
            using StiveController context = new();

            Utilisateur utilisateur = context.Utilisateurs.Where(c => c.Id_utilisateur == id).First();
            utilisateur.Nom = Nom;
            utilisateur.Prenom = Prenom;
            utilisateur.Email = Email;
            utilisateur.Password = Password;
            utilisateur.Telephone=Telephone;
            utilisateur.Id_lieu=Id_lieu;
            utilisateur.Id_role =Id_role;

            context.Update(utilisateur);
            context.SaveChanges();
        }

        [HttpDelete(Name = "DeleteUtilisateur")]
        public void DeleteUtilisateur(int id)
        {
            using StiveController context = new();

            Utilisateur utilisateur = context.Utilisateurs.Where(c => c.Id_utilisateur == id).First();

            context.Remove(utilisateur);
            context.SaveChanges() ; 
        }

        [HttpGet(Name = "GetAllUtilisateur")]
        public List<Utilisateur> GetAllUtilisateur()
        {
            using StiveController context = new();

            List<Utilisateur> utilisateurs = context.Utilisateurs.ToList();
            return utilisateurs;
        }

        [HttpGet(Name = "GetUtilisateurById")]
        public Utilisateur GetUtilisateurById(int id) 
        {
            using StiveController context = new();

            Utilisateur utilisateur = context.Utilisateurs.Where(c => c.Id_utilisateur == id).First();
            return utilisateur;
        }
    }
}
