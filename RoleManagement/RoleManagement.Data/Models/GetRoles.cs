using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleManagement.Data.Models
{
    public class GetRoles
    {
        public int? id { get; set; }
        [Required(ErrorMessage ="RoleName is necessary")]
        [StringLength(15,ErrorMessage ="Can have upto 15 Characters")]
        public string RoleName { get; set; }
        [Required(ErrorMessage = "RoleTypeId is necessary")]
        public int RoleTypeId { get; set; }
      
        public string RoleType { get; set; }
        [Required(ErrorMessage ="Date is necessary")]
        public DateTime EffectiveFrom { get; set; }
        public DateTime? CreateDate { get; set; }
        
    }
}
