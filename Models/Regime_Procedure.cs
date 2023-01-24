using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Regime_Procedure
    {
        public int Id { get; set; }
        public int RegimeId { get; set; }
        public Regime Regime { get; set; }
        public int ProcedureId { get; set; }
        public Procedure Procedure { get; set; }
        public int LangueId { get; set; }
        public Langue Langue { get; set; }
    }
}
