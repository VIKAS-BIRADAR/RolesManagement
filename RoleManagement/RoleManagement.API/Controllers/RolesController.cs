using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using RoleManagement.Data.Models;
using System.Data.SqlClient;
using System.Configuration;
using RoleManagement.Services;
using RoleManagement.Services.Services;
using System.Web.Http.Description;

namespace RoleManagement.API.Controllers
{
    [RoutePrefix("api/Roles")]
    public class RolesController : ApiController
    {
        [HttpGet]

        public IEnumerable<GetRoles> Get()
        {
            try
            {

                RolesService obj = new RolesService();
                List<GetRoles> modelRoles = obj.GetRoleDetails();
                return modelRoles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [ResponseType(typeof(GetRoles))]
        public string Post(GetRoles obj)
        {
            try
            {
                RolesService obj1 = new RolesService();
                Int32 message = 0;

                if ((obj.RoleName != null) && (obj.EffectiveFrom != null)) message = obj1.InsertUpdateRole(obj);
                else message = -1;
                return message.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpDelete]
        public string Delete(int id)

        {
            try
            {
                RolesService obj = new RolesService();
                Int32 message = 0;
                message = obj.DeleteRoles(id);
                return message.ToString();
            }
            catch
            {
                throw;
            }
        }

    }

}
