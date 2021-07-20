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
using log4net;

namespace RoleManagement.API.Controllers
{
    [RoutePrefix("api/Roles")]
    
    public class RolesController : ApiController
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RolesController));
        [HttpGet]
        public IEnumerable<GetRoles> Get()
        {
            try
            {
                Logger.Debug("Calling the  get Role details service file");
                RolesService obj = new RolesService();
                List<GetRoles> modelRoles = obj.GetRoleDetails();
                Logger.Info("Successfully able to get role details");
                return modelRoles;
            }
            catch (Exception ex)
            {
                Logger.Error("Failed to retreive Role details .", ex);
                throw ex;
            }
        }

        [HttpPost]

        [ResponseType(typeof(GetRoles))]
        public string Post(GetRoles obj)
        {
            try
            {
                     Logger.Debug("Calling the  InsertUpdateRole details service function");
                     RolesService obj1 = new RolesService();
                    Int32 message = 0;
                    if ((obj.RoleName != null) && (obj.EffectiveFrom != null)) message = obj1.InsertUpdateRole(obj);
                    else message = -1;
                    Logger.Info("Successfully able to get role details");
                    return message.ToString();
            }
            catch (Exception e)
            {
                Logger.Error("Failed to retreive Role details .", e);
                throw e;
            }
        }
        [HttpDelete]
        public string Delete(int id)
        {
            try
            {
                Logger.Debug("Calling the  Delete details service function");
                RolesService obj = new RolesService();
                Int32 message = 0;
                message = obj.DeleteRoles(id);
                Logger.Info("Successfully able to get role details");
                return message.ToString();
            }
            catch
            {
                Logger.Error("Failed to delete Role details .");
                throw;
            }
        }

    }

}
