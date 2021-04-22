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
    public class RolesController : ApiController
    {
        [HttpGet]
        public Roles Get()
        {
            try
            {
                RolesService obj = new RolesService();
                Roles modelRoles = obj.GetRoleDetails();
                return modelRoles;
            }
            catch(Exception e) 
            {
                throw e;
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

    }
    
}
