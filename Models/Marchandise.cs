using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Marchandise
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int LangueId { get; set; }
        public Langue Langue { get; set; }
        public List<Regle_Marchandise> Regles_Marchandises { get; set; }
        public List<Mesure_Marchandise> Mesures_Marchandises { get; set; }
    }
}
