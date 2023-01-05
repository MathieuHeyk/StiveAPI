using Microsoft.AspNetCore.Mvc;
using StiveAPI.Helpers;
using StiveAPI.Models;

namespace StiveAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ArticleController
    {
        [HttpPost(Name ="AddArticle")]
        public void AddArticle(string nom , double prix_unitaire, double prix_carton,int annee, int id_famille, int id_fournisseur)
        {

      
         using StiveController context = new ();
        Article article = new Article();
            article.Nom = nom;
            article.Prix_unitaire = prix_unitaire;
            article.Prix_carton = prix_carton;
            article.Annee = annee;
            article.ID_famille = id_famille;
            article.ID_fournisseur = id_fournisseur;
            context.Add(article);
            context.SaveChanges();


        }

        [HttpPut(Name = "EditArticle")]
        public void EditArticle(int id, string nom, double prix_unitaire, double prix_carton, int annee, int id_famille, int id_fournisseur)
        {
            using StiveController context = new();

            Article article = context.Articles.Where(a => a.Id == id).First();
            article.Id =id;
            article.Nom = nom;
                article.Prix_unitaire = prix_unitaire;
                article.Prix_carton = prix_carton;
                article.Annee = annee;
                article.ID_famille = id_famille;
                article.ID_fournisseur = id_fournisseur;
                context.Update(article);
                context.SaveChanges();
            


            context.Update(article);
            context.SaveChanges();
        }
        [HttpDelete(Name = "DeleteArticle")]
        public void DeleteArticle(int id)
        {
            using StiveController context = new();

            Article article = context.Articles.Where(a=> a.Id == id).First();
          

            context.Remove(article);
            context.SaveChanges();
        }

        [HttpGet(Name = "GetAllArticles")]
        public List<Article> GetAllArticles()
        {
            using StiveController context = new();

            List<Article> articles = context.Articles.ToList();
            return articles;
        }

        [HttpGet(Name = "GetArticlesById")]
        public Article GetArticleById(int id)
        {
            using StiveController context = new();

            Article article = context.Articles.Where(a=> a.Id == id).First();
            return article;
        }


    }
}
