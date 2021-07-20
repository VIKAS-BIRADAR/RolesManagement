using RoleManagement.Data;
using RoleManagement.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace RoleManagement.Services
{
   
    public class RoleTypeService : IRoleTypeService
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RoleTypeService));
        public List<RoleType> GetRoleTypeData()
        {
            dbConnector objConn = new dbConnector();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();

            try
            {
                Logger.Debug("able to retreive the roletypeservice from database");
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
                    Logger.Info("Successfully able  to retreive data from database");


                }

                return _listRoleType;
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

