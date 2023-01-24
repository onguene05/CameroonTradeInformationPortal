using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Organisation
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int LangueId { get; set; }
        public Langue Langue { get; set; }

        //relation
        public List<Procedure> Procedures { get; set; }
    }
}
