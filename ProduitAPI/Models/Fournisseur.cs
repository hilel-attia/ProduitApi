using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProduitAPI.Models
{
    public class Fournisseur
    {

        public Fournisseur()
        {
            Commande_frss = new HashSet<Commande_frs>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdFO { get; set; }
        public string Codetva { get; set; }
        public string Codefrs { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Pays { get; set; }
        public string Raiso { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Timbre { get; set; }
        public string Ville { get; set; }

        public virtual ICollection<Commande_frs> Commande_frss { get; set; }
        
        //Relation commandefrs
        public Guid IdFac { get; set; }
        public FactureFrs FactureFrs { get; set; }

    }
}
