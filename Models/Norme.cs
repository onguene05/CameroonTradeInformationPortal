using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Norme
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public string Fichier { get; set; }
        public DateTime Date_Publication { get; set; }
        public string status { get; set; }
        public List<Produit> Produits { get; set; }
        public int LangueId { get; set; }
        public Langue Langue { get; set; }
    }
}
