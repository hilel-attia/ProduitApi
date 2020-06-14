using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace ProduitAPI.Models
{
    public class FactureFrs
    {

        public FactureFrs()
        {


            LigneFactureFrss = new HashSet<LigneFactureFrs>();

        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdFac { get; set; }
        public DateTime dateFac { get; set; }
        public String NumFac { get; set; }
        public String EtatFac { get; set; }
        public Double Mnttva { get; set; }
        public Double MinTnet { get; set; }
        public Double Mnthtva { get; set; }

        public String DroitTimbre { get; set; }

        public Commande_frs Commande_frs { get; set; }
        public Fournisseur Fournisseur { get; set; }
        public ICollection<LigneFactureFrs> LigneFactureFrss { get; set; }
    }
}
