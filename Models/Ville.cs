using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Ville
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public int LangueId { get; set; }
        public Langue Langue { get; set; }
    }
}
