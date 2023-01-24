using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public List<Categorie_Article> Categories_Articles { get; set; }
        public int LangueId { get; set; }
        public Langue Langue { get; set; }
    }
}
