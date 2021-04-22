using RoleManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleManagement.Services.Services
{
    public class RolesService
    {
        public Roles GetRoleDetails()
        {

            dbConnector objConn = new dbConnector();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();

            try
            {
                Roles obj = new Roles();

                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("GetData", Conn);
                objCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader _Reader = objCommand.ExecuteReader();

               

                while (_Reader.Read())
                {
                    obj.id= Convert.ToInt32(_Reader["id"]);
                    obj.Name = _Reader["Name"].ToString();
                    obj.RoleTypeId = Convert.ToInt32(_Reader["RoleTypeId"]);
                    obj.EffectiveFrom = Convert.ToDateTime(_Reader["EffectiveFrom"]);
                    obj.isActive = Convert.ToInt32(_Reader["isActive"]);
                    obj.CreateDate = Convert.ToDateTime(_Reader["CreateDate"]);
                    obj.ModifyDate = Convert.ToDateTime(_Reader["ModifyDate"]);


                }

                return obj;
            }
            catch
            {
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
        public Int32 InsertRole(Roles obj)
        {
            dbConnector objConn = new dbConnector();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();

            int result = 0;

            try
            {
                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("InsertData", Conn);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddWithValue("@Name", obj.Name);
                objCommand.Parameters.AddWithValue("@RoleTypeId", obj.RoleTypeId);
                objCommand.Parameters.AddWithValue("@EffectiveFrom", obj.EffectiveFrom);
                objCommand.Parameters.AddWithValue("@isActive", obj.isActive);
                objCommand.Parameters.AddWithValue("@CreateDate", obj.CreateDate);
                objCommand.Parameters.AddWithValue("@ModifyDate", obj.ModifyDate);

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
