using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Compte
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public String Email { get; set; }
        public String password { get; set; }
        public String Status { get; set; }
        public List<Role_Compte> Roles_Comptes { get; set; }
    }
}
