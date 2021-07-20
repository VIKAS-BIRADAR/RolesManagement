using RoleManagement.Data.Models;
using RoleManagement.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace RoleManagement.Services.Services
{
    public class RolesService : IRolesService
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RolesService));

        public List<GetRoles> GetRoleDetails()
        {
            dbConnector objConn = new dbConnector();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();

            try
            {
                Logger.Debug("able to get the roles service details");
                List<GetRoles> _listGetRoles = new List<GetRoles>();

                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("spGetRole", Conn);
                objCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader _Reader = objCommand.ExecuteReader();



                while (_Reader.Read())
                {
                    GetRoles obj = new GetRoles();
                    obj.id = Convert.ToInt32(_Reader["id"]);
                    obj.RoleName = _Reader["RoleName"].ToString();
                    obj.RoleType = _Reader["RoleType"].ToString();
                    obj.RoleTypeId = Convert.ToInt32(_Reader["RoleTypeId"]);
                    obj.EffectiveFrom = Convert.ToDateTime(_Reader["EffectiveFrom"]);
                    obj.CreateDate = Convert.ToDateTime(_Reader["CreateDate"]);

                    _listGetRoles.Add(obj);


                }
                Logger.Info("able to retreive data from database");
                return _listGetRoles;
            }
            catch
            {
                Logger.Error("Failed to retreive user details .");
                throw;
            }
            finally
            {
                if (Conn != null)
                {
                    if (Conn.State == ConnectionState.Open)
                    {
                        Conn.Close();
                        Conn.Dispose();
                    }
                }
            }
        }
        public Int32 InsertUpdateRole(GetRoles obj)
        {
            dbConnector objConn = new dbConnector();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();

            int result = 0;

            try
            {
                Logger.Debug("able to post and update the roles service");
                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("spSaveRole", Conn);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddWithValue("@R_id", obj.id);
                objCommand.Parameters.AddWithValue("@R_Name", obj.RoleName);
                objCommand.Parameters.AddWithValue("@R_RoleTypeId", obj.RoleTypeId);
                objCommand.Parameters.AddWithValue("@R_EffectiveFrom", obj.EffectiveFrom);
                

                result = Convert.ToInt32(objCommand.ExecuteScalar());

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                Logger.Error("Failed to retreive user details .");
                throw;
            }
            finally
            {
                if (Conn != null)
                {
                    if (Conn.State == ConnectionState.Open)
                    {
                        Conn.Close();
                        Conn.Dispose();
                    }
                }
            }
        }
   
        public Int32 DeleteRoles(int id)
        {
            dbConnector objConn = new dbConnector();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();

            int result = 0;

            try
            {
                Logger.Debug("able to delete the roles service");
                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("spDeleteRole", Conn);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddWithValue("@R_id", id);
                result = Convert.ToInt32(objCommand.ExecuteScalar());

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                Logger.Error("Failed to retreive user details .");
                throw;
            }
            finally
            {
                if (Conn != null)
                {
                    if (Conn.State == ConnectionState.Open)
                    {
                        Conn.Close();
                        Conn.Dispose();
                    }
                }
            }
        }

    }
}
