using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Procedure
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int OrganisationId { get; set; }
        public Organisation Organisation { get; set; }
        public int LangueId { get; set; }
        public Langue Langue { get; set; }
        public ICollection<Regime_Procedure> Regimes_Procedures { get; set; }
        public List<Mesure> Mesures { get; set; }
        public List<Regle> Regles { get; set; }
    }
}
