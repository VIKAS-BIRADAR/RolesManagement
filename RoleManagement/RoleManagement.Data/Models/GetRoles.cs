using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleManagement.Data.Models
{
    public class GetRoles
    {
        public int id { get; set; }
        public string RoleName { get; set; }
        public string RoleType { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime CreateDate { get; set; }
        
    }
}
