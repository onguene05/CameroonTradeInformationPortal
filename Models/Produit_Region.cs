using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Produit_Region
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public int ProduitId { get; set; }
        public Produit Produit { get; set; }
    }
}
