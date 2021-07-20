using RoleManagement.Data.Models;
using RoleManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using log4net;

namespace RoleManagement.API.Controllers
{
    [RoutePrefix("api/Login")]
    public class LoginController : ApiController
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LoginController));
        [HttpGet]
        public IEnumerable<Login> Get()
        {
            try
            {
                Logger.Debug("Calling the  get login details service file");
                LoginService obj = new LoginService();
                List<Login> modelRoles = obj.GetLoginDetails();
                Logger.Info("Successfully able to get login details");
                return modelRoles;
            }
            catch (Exception ex)
            {
                Logger.Error("Failed to retreive user details .", ex);
                throw ex;
            }
        }

        [HttpPost]
        [ResponseType(typeof(Login))]
        public string Post(Login obj)
        {
         try
            {
                Logger.Info("Calling the  validate login details service file");
                LoginService obj1 = new LoginService();
                Int32 message = 0;
                if ((obj.Email != null) && (obj.Password != null)) message = obj1.ValidateLogin(obj);
                else message = -1;
                Logger.Debug("Successfully able to validate login details");
                return message.ToString();
            }
            catch (Exception e)
            {
                Logger.Error("Failed to retreive user details .", e);
                throw e;
            }
        }

        [HttpPost]
        [Route("resetPassword")]
        [ResponseType(typeof(Login))]
        public string resetPassword(Login obj)
        {
            try
            {
                Logger.Debug("Calling the reset password service file");
                LoginService obj2 = new LoginService();
                Int32 message = 0;
                if ((obj.Email != null) && (obj.Password != null) && (obj.NewPassword != null)) message = obj2.resetPassword(obj);
                else message = -1;
                Logger.Debug("Successfully able to reset password login details");
                return message.ToString();
            }
            catch (Exception e)
            {
                Logger.Error("Failed to retreive user details .", e);
                throw e;
            }
        }
    }
}
