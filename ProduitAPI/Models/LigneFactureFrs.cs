using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProduitAPI.Models
{
    public class LigneFactureFrs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdLi { get; set; }
        public Double NumCMD { get; set; }
        public Double Qte { get; set; }
        public Double Taux_tva { get; set; }

        public Double Puttcnet { get; set; }


        public Guid IdFac { get; set; }
        public FactureFrs FactureFrs { get; set; }
    }
}
