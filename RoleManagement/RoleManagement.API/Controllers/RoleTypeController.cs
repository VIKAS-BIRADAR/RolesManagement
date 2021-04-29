using RoleManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RoleManagement.Services;
using System.Web.Http.Description;

namespace RoleManagement.API.Controllers
{
    public class RoleTypeController : ApiController
    {
        [HttpGet]

        public IEnumerable<RoleType> Get()
        {
            try
            {

                RoleTypeService obj = new RoleTypeService();
                List<RoleType> modelRoles = obj.GetRoleTypeData();
                return modelRoles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
