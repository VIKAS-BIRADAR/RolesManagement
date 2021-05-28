using RoleManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleManagement.Services.Contracts
{
    interface IRoleTypeService
    {
        List<RoleType> GetRoleTypeData();
    }
}
