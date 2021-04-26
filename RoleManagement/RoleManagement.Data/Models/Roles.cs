using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleManagement.Data.Models
{
    public class Roles
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int RoleTypeId { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public bool isActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
    }
}
