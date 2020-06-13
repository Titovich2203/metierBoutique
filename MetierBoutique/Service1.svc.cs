using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MetierBoutique.Model;

namespace MetierBoutique
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        private bdBoutiqueContext db = new bdBoutiqueContext();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string Hello()
        {
            return "Bonjour !!!";
        }

        public List<Categorie> getListeCategorie()
        {
            return db.categories.ToList();
        }

        public Categorie getCategorieById(int id)
        {
            return db.categories.Find(id);
        }

        public bool addCategorie(Categorie categorie)
        {
            bool rep = false;
            try
            {
                db.categories.Add(categorie);
                db.SaveChanges();
                rep = true;
            }
            catch (Exception ex)
            {

            }
            return rep;
        }

        public bool updateCategorie(Categorie categorie)
        {
            bool rep = false;
            try
            {
                db.Entry(categorie).State = EntityState.Modified;
                db.SaveChanges();
                rep = true;
            }
            catch (Exception ex)
            {

            }
            return rep;
        }

        public bool deleteCategorie(int id)
        {
            bool rep = false;
            try
            {
                Categorie categorie = db.categories.Find(id);
                db.categories.Remove(categorie);
                db.SaveChanges();
                rep = true;
            }
            catch (Exception ex)
            {

            }
            return rep;
        }

        public List<Produit> getListeProduit()
        {
            return db.produits.ToList();
        }

        public Produit getProduitById(int id)
        {
            return db.produits.Find(id);
        }

        public bool addProduit(Produit produit)
        {
            bool rep = false;
            try
            {
                db.produits.Add(produit);
                db.SaveChanges();
                rep = true;
            }
            catch (Exception ex)
            {

            }
            return rep;
        }

        public bool updateProduit(Produit produit)
        {
            bool rep = false;
            try
            {
                db.Entry(produit).State = EntityState.Modified;
                db.SaveChanges();
                rep = true;
            }
            catch (Exception ex)
            {

            }
            return rep;
        }

        public bool deleteProduit(int id)
        {
            bool rep = false;
            try
            {
                Produit p = db.produits.Find(id);
                db.produits.Remove(p);
                db.SaveChanges();
                rep = true;
            }
            catch (Exception ex)
            {

            }
            return rep;
        }
    }
}
