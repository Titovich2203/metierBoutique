using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetierBoutique.Model
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(10), Required]
        public string CodeCategorie { get; set; }

        [MaxLength(100), Required]
        public string DesignationCategorie { get; set; }
    }
}