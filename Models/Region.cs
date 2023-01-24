using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Nom { get; set; }
        public int Description { get; set; }
        public List<Produit_Region> Produits_Regions { get; set; }
        public List<Ville> Villes { get; set; }
        public int LangueId { get; set; }
        public Langue Langue { get; set; }
    }
}
