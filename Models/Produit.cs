using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int TarifId { get; set; }
        public Tarif_Douanier Tarif { get; set; }
        public int NormeId { get; set; }
        public Norme Norme { get; set; }
        public List<Mesure_Produit> Mesures_Produits { get; set; }
        public List<Produit_Region> Produits_Regions { get; set; }
        public int LangueId { get; set; }
        public Langue Langue { get; set; }
    }
}
