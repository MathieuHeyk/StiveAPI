using Microsoft.AspNetCore.Mvc;
using StiveAPI.Helpers;
using StiveAPI.Models;

namespace StiveAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class FamilleController
    {
        [HttpPost(Name = "AddFamille")]
        public void AddFamille(string Libelle)
        {
            using StiveController context = new();

            Famille famille = new();
            famille.Libelle = Libelle;

            context.Add(famille);
            context.SaveChanges();
        }

        [HttpPut(Name = "EditFamille")]
        public void EditFamille(int id, string libelle)
        {
            using StiveController context = new();

            Famille famille = context.Familles.Where(c => c.Id_famille == id).First();
            famille.Libelle = libelle;

            context.Update(famille);
            context.SaveChanges();
        }

        [HttpDelete(Name = "DeleteFamille")]
        public void DeleteFamille(int id)
        {
            using StiveController context = new();
            Famille famille = context.Familles.Where(c => c.Id_famille == id).First();

            context.Remove(famille);
            context.SaveChanges();
        }

        [HttpGet(Name = "GetAllFamille")]
        public List<Famille> GetAllFamille()
        {
            using StiveController context = new();

            List<Famille> famille = context.Familles.ToList();
            return famille;
        }

        [HttpGet(Name = "GetFamilleById")]
        public Famille GetFamilleById(int id)
        {
            using StiveController context = new();

            Famille famille = context.Familles.Where(c => c.Id_famille == id).First();
            return famille;
        }
    }
}

