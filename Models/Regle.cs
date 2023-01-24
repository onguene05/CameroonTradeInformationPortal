using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Regle
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public string Fichier { get; set; }
        public DateTime DatePublication { get; set; }
        public string Status { get; set; }
        public int LoiId { get; set; }
        public Loi Loi { get; set; }
        public List<Regle_Marchandise> Regles_Marchandises { get; set; }
        public int LangueId { get; set; }
        public Langue Langue { get; set; }
    }
}
