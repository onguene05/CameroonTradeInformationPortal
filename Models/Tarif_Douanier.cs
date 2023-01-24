using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Tarif_Douanier
    {
        public int Id { get; set; }
        public string Code_SH { get; set; }
        public double Taux { get; set; }
        public string Unite { get; set; }
        public DateTime Date_Debut { get; set; }
        public DateTime Date_Fin { get; set; }
        public int MarchandiseId { get; set; }
        public Marchandise Marchandise { get; set; }
        public List<Produit> Produits { get; set; }
        public int LangueId { get; set; }
        public Langue Langue { get; set; }
    }
}
