using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Mesure_Produit
    {
        public int Id { get; set; }
        public int MesureId { get; set; }
        public Mesure Mesure { get; set; }
        public int ProduitId { get; set; }
        public Produit Produit { get; set; }
    }
}
