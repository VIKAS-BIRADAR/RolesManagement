using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleManagement.Data.Models
{
    public class RoleType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool isActive { get; set; }
    }
}
