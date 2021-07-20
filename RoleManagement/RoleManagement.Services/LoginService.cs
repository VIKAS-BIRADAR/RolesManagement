using RoleManagement.Data.Models;
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

    public class LoginService
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LoginService));
        public List<Login> GetLoginDetails()
        {
            dbConnector objConn = new dbConnector();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();

            try
            {
                Logger.Debug("Entered the get login details file");
                List<Login> _listLogin = new List<Login>();

                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("spGetLogin", Conn);
                objCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader _Reader = objCommand.ExecuteReader();
                
                while (_Reader.Read())
                {
                    Login obj = new Login();
                    obj.FirstName = _Reader["FirstName"].ToString();
                    obj.LastName = _Reader["LastName"].ToString();
                    obj.Email = _Reader["Email"].ToString();
                    obj.Username = _Reader["Username"].ToString();
                    obj.Password = _Reader["Password"].ToString();
                    _listLogin.Add(obj);
                }
                Logger.Info("able to retreive data from database");
                return _listLogin;
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
        public Int32 ValidateLogin(Login obj)
        {
            dbConnector objConn = new dbConnector();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();

            int result = '0';

            try
            {
                Logger.Info("entered the  validate login details service function");
                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("spValidateUser", Conn);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddWithValue("@R_Email", obj.Email);
                objCommand.Parameters.AddWithValue("@R_Password", obj.Password);
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
        public Int32 resetPassword(Login obj)
        {
            dbConnector objConn = new dbConnector();
            SqlConnection Conn = objConn.GetConnection;
            Conn.Open();

            int result = '0';

            try
            {
                Logger.Debug("Entered the reset password service function");
                if (Conn.State != System.Data.ConnectionState.Open) Conn.Open();

                SqlCommand objCommand = new SqlCommand("spResetPassword", Conn);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.AddWithValue("@Email", obj.Email);
                objCommand.Parameters.AddWithValue("@Password", obj.Password);
                objCommand.Parameters.AddWithValue("@NewPassword", obj.NewPassword);
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
                Logger.Error("Exception raised .");
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
