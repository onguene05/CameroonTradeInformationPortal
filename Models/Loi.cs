using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Loi
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public string Fichier { get; set; }
        public DateTime DatePublication { get; set; }
        public string Status { get; set; }
        public List<Mesure> Mesures { get; set; }
        public List<Regle> Regles { get; set; }
        public int LangueId { get; set; }
        public Langue Langue { get; set; }
    }
}
