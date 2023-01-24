using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Regle_Marchandise
    {
        public int Id { get; set; }
        public int RegleId { get; set; }
        public Regle Regle { get; set; }
        public int MarchandiseId { get; set; }
        public Marchandise Marchandise { get; set; }
    }
}
