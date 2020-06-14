using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace ProduitAPI.Models
{
    public class Paquet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdPA { get; set; }
        public String CodeFaq { get; set; }
        public Double Epaisseur { get; set; }
        public Double Largeur { get; set; }

        public Double Longeur { get; set; }
        public Double Quantite { get; set; }

        //Relation article
        public Guid IdAR { get; set; }
        public Article Article { get; set; }
    }
}
