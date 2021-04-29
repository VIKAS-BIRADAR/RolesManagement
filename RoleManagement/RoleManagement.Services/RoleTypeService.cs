using RoleManagement.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleManagement.Services
{
    public class RoleTypeService
    {
        public List<RoleType> GetRoleTypeData()
        {
            dbConnector objConn = new dbConnector();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();

            try
            {
                List<RoleType> _listRoleType = new List<RoleType>();

                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("spGetRoleType", Conn);
                objCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader _Reader = objCommand.ExecuteReader();



                while (_Reader.Read())
                {
                    RoleType obj = new RoleType();
                    obj.ID = Convert.ToInt32(_Reader["ID"]);
                    obj.Name = _Reader["Name"].ToString();
                    obj.isActive = Convert.ToBoolean(_Reader["isActive"]);
                    _listRoleType.Add(obj);


                }

                return _listRoleType;
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

