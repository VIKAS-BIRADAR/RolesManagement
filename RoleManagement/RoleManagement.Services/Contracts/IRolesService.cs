using RoleManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleManagement.Services.Contracts
{
    interface IRolesService
    {
            List<GetRoles> GetRoleDetails();
            int InsertUpdateRole(GetRoles obj);
            int DeleteRoles(int id);
    }
}
