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
        [HttpPost]
        [ResponseType(typeof(RoleType))]
        public string Post(RoleType obj)
        {
            try
            {
                RoleTypeService obj1 = new RoleTypeService();
                Int32 message = 0;

                if ((obj.Name != null) ) message = obj1.InsertRole(obj);
                else message = -1;
                return message.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [HttpPut]
        [ResponseType(typeof(RoleType))]
        public string Edit(RoleType obj)
        {
            try
            {
                RoleTypeService obj1 = new RoleTypeService();
                Int32 message = 0;
                message = obj1.UpdateRoleType(obj);
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
                RoleTypeService obj = new RoleTypeService();
                Int32 message = 0;
                message = obj.DeleteRoleType(id);
                return message.ToString();
            }
            catch
            {
                throw;
            }
        }
    }
}
