namespace StiveAPI.Models
{
	public class Article
	{
		public int Id { get; set; }
		public string Nom { get; set; }
		public double Prix_unitaire { get; set; }
		public double Prix_carton { get; set; }
		public int Annee { get; set; }
		public int ID_famille { get; set; }
		public int ID_fournisseur { get; set; }


		public Article( int id, string nom, double prix_unitaire, double prix_carton, int annee, int id_famille, int id_fournisseur )
		{
			Id = id;
			Nom = nom;
			Prix_unitaire = prix_unitaire;
			Prix_carton = prix_carton;
			Annee = annee;
			ID_famille = id_famille;
			ID_fournisseur = id_fournisseur;
		}
	}
}
