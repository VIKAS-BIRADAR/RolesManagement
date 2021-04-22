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


    }
}
