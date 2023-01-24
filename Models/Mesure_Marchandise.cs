using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Mesure_Marchandise
    {
        public int Id { get; set; }
        public int MesureId { get; set; }
        public Mesure Mesure { get; set; }
        public int MarchandiseId { get; set; }
        public Marchandise Marchandise { get; set; }
    }
}
