using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Mesure
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Type { get; set; }
        public string Fichier { get; set; }
        public string Description { get; set; }
        public DateTime DatePublication { get; set; }
        public string Status { get; set; }
        public int LoiId { get; set; }
        public Loi Loi { get; set; }
        public int ProcedureId { get; set; }
        public Procedure Procedure { get; set; }
        public int LangueId { get; set; }
        public Langue Langue { get; set; }
        public List<Mesure_Produit> Mesures_Produits { get; set; }
        public List<Mesure_Marchandise> Mesures_Marchandises { get; set; }
    }
}
