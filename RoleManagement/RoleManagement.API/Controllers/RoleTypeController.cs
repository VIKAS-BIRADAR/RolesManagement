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
        public IEnumerable<RoleType> GetRoleType()
        {
            try
            {

                RoleTypeService obj = new RoleTypeService();
                List<RoleType> modelRoleType = obj.GetRoleTypeData();
                return modelRoleType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
