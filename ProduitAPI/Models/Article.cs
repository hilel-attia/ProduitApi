using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProduitAPI.Models
{
    public class Article
    {
        public Article()
        {

            Commande_frss = new HashSet<Commande_frs>();
            Paquets = new HashSet<Paquet>();

        }







        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdAR { get; set; }
        public string Codeart { get; set; }
        public string Codetva { get; set; }
        public string Designation { get; set; }
        public string Unite { get; set; }
        public string Fammile_art { get; set; }
        public int Taux_tva { get; set; }
        public int Remise { get; set; }
        public double Purbht { get; set; }
        public double Pudttc { get; set; }
        public double Purnht { get; set; }

        //relations
             public ICollection<Commande_frs> Commande_frss { get; set; }
        public ICollection<Paquet> Paquets { get; set; }
    }
}
