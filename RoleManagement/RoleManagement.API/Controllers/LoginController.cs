using RoleManagement.Data;
using RoleManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace RoleManagement.API.Controllers
{
    [RoutePrefix("api/Login")]
    public class LoginController : ApiController
    {
        [HttpPost]
        [ResponseType(typeof(Login))]
        public string Post(Login obj)
        {

            try
            {
                LoginService obj1 = new LoginService();
                Int32 message = 0;
                if ((obj.Username != null) && (obj.Password != null)) message = obj1.ValidateLogin(obj);
                else message = -1;
                return message.ToString();
            }

            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
