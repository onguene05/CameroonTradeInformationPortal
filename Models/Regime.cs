using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Regime
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public int LangueId { get; set; }
        public Langue Langue { get; set; }
        public ICollection<Regime_Procedure> Regimes_Procedures { get; set; }
    }
}
