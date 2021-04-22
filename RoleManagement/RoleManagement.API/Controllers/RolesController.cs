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

        public IEnumerable<Roles> Get()
        {
            try
            {

                RolesService obj = new RolesService();
                List<Roles> modelRoles = obj.GetRoleDetails();
                return modelRoles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [ResponseType(typeof(Roles))]
        public string Post(Roles obj)
        {
            try
            {
                RolesService obj1 = new RolesService();
                Int32 message = 0;

                if ((obj.Name != null) && (obj.EffectiveFrom != null)) message = obj1.InsertRole(obj);
                else message = -1;
                return message.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpPut]
        [ResponseType(typeof(Roles))]
        public string Edit(Roles obj)
        {
            try
            {
                RolesService obj1 = new RolesService();
                Int32 message = 0;
                message = obj1.UpdateRoles(obj);
                return message.ToString();

            }
            catch
            {
                throw;
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
