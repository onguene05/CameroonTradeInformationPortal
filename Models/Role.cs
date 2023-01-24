using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Status { get; set; }
        public List<Role_Compte> Roles_Comptes { get; set; }
    }
}
