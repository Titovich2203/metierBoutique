using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierBoutique.Model
{
    public class Produit
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(4), Required]
        public string CodeProduit { get; set; }

        [MaxLength(100), Required]
        public string DesignationProduit { get; set; }

        public double QuantiteQritique { get; set; }

        public double Pu { get; set; }

        [MaxLength(100)]
        public string Image { get; set; }

        public int IdCategorie { get; set; }

        //[ForeignKey("IdCategorie")]
        //public virtual Categorie Categorie { get; set; }
    }
}