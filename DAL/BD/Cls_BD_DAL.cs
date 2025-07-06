using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Common.Cache;


namespace DAL.BD
{
    public class Cls_BD_DAL
    {

        private SqlConnection _Obj_SQL_CNX;
        private SqlDataAdapter _Obj_SQL_DAP;
        private SqlCommand _Obj_SQL_CMD;

        private string _sNombCNXConfig;

        private DataSet _Ds;

        private DataTable _Dt_Parametros;

        private string _sCadena, _sMsjError, _sNombSP;
        private string _sValorScalar;

        public SqlConnection Obj_SQL_CNX { get => _Obj_SQL_CNX; set => _Obj_SQL_CNX = value; }
        public SqlDataAdapter Obj_SQL_DAP { get => _Obj_SQL_DAP; set => _Obj_SQL_DAP = value; }
        public SqlCommand Obj_SQL_CMD { get => _Obj_SQL_CMD; set => _Obj_SQL_CMD = value; }
        public string sNombCNXConfig { get => _sNombCNXConfig; set => _sNombCNXConfig = value; }
        public DataSet Ds { get => _Ds; set => _Ds = value; }
        public DataTable Dt_Parametros { get => _Dt_Parametros; set => _Dt_Parametros = value; }
        public string sCadena { get => _sCadena; set => _sCadena = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public string sNombSP { get => _sNombSP; set => _sNombSP = value; }
        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }

               





    }


    public abstract class ConnectiontoSql
    {
        private readonly string connectionString;
        public ConnectiontoSql()
        {
            connectionString = "Server=DESKTOP-6BRVLJ4;DataBase=RESIDENCIA_GERIATRICA; integrated security =true";
        }
        protected SqlConnection Getconnection()
        {
            return new SqlConnection(connectionString);
        }
    }


    public class UserDao : ConnectiontoSql
    {
        public bool login(string user, string pass)
        {
            try
            {

                using (var connection = Getconnection())
                {

                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM PERSONAL WHERE Cedula_Per=@user AND Password=@pass ";
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@pass", pass);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UserLoginCache.IdPersonal = reader.GetString(0);
                                UserLoginCache.Nombre = reader.GetString(2);
                                UserLoginCache.Apellidos = reader.GetString(3);
                                UserLoginCache.Correo = reader.GetString(6);
                                UserLoginCache.Cargo = reader.GetString(9);
                            }

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }


                }

            }
            catch (Exception ex)
            {

                return true;
                //Cls_BD_DAL ERROR = new Cls_BD_DAL();
               
                //ERROR.sMsjError = ex.Message.ToString();
                
            }
            

           
        }
    }


    public class UserModel
    {
        UserDao userDao = new UserDao();

        public bool LoginUser(string user, string pass)
        {
            return userDao.login(user, pass);
        }

        //public bool editPassword(string user, string pass)
        //{
        //    if (user== UserLoginCache.IdPersonal)
        //    {

        //    }
        //    return true;
        //}


    }



}
