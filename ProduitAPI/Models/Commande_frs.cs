using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProduitAPI.Models
{
    public class Commande_frs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdCO { get; set; }
        public String Etatcmd { get; set; }
        public String Nomcmd { get; set; }
        public DateTime Datecmd { get; set; }
        public Double Mntnet { get; set; }
        public Double Mnttva { get; set; }

        //Relation article
        public Guid IdAR { get; set; }
        public Article Article { get; set; }
        //Relation Fournisseur
        public Guid IdFO { get; set; }
        public Fournisseur Fournisseur { get; set; }
        //Relation facture

        //Relation commandefrs
        public Guid IdFac { get; set; }
        public FactureFrs FactureFrs { get; set; }
       
    }
}
