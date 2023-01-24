using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameroonTradeInformationPortal.Models
{
    public class Role_Compte
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int CompteId { get; set; }
        public Compte Compte { get; set; }
        public String Status { get; set; }
    }
}
