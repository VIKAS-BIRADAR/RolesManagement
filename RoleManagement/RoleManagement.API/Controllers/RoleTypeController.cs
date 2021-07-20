using RoleManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RoleManagement.Services;
using System.Web.Http.Description;
using log4net;

namespace RoleManagement.API.Controllers
{
    public class RoleTypeController : ApiController
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RoleTypeController));
        [HttpGet]
        public IEnumerable<RoleType> GetRoleType()
        {
            try
            {
                Logger.Debug("Calling the Get role types details service function");
                RoleTypeService obj = new RoleTypeService();
                List<RoleType> modelRoleType = obj.GetRoleTypeData();
                Logger.Info("Successfully able to get  role type details");
                return modelRoleType;
            }
            catch (Exception ex)
            {
                Logger.Error("Failed to retreive Role type details .", ex);
                throw ex;
            }
        }
    }
}
