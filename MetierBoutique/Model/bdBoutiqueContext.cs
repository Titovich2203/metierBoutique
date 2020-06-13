using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace MetierBoutique.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class bdBoutiqueContext:DbContext
    {
        public bdBoutiqueContext() : base("ConnBoutique") { }
        public DbSet<Categorie> categories { get; set; }
        public DbSet<Produit> produits { get; set; }
    }
}