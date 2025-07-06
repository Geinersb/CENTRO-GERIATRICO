using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL.BD;

namespace BLL.BD
{
   public class CLS_BD_BLL
    {

        public void ExecDataAdapter(ref Cls_BD_DAL Obj_DB_DAL)
        {
            try
            {
                Obj_DB_DAL.sCadena = ConfigurationManager.ConnectionStrings[Obj_DB_DAL.sNombCNXConfig].ToString();


                Obj_DB_DAL.Obj_SQL_CNX = new SqlConnection(Obj_DB_DAL.sCadena);

                if (Obj_DB_DAL.Obj_SQL_CNX.State == ConnectionState.Closed)
                {
                    Obj_DB_DAL.Obj_SQL_CNX.Open();
                }

                Obj_DB_DAL.Obj_SQL_DAP = new SqlDataAdapter(Obj_DB_DAL.sNombSP, Obj_DB_DAL.Obj_SQL_CNX);


                #region AGREGAR PARAMETROS

                if ((Obj_DB_DAL.Dt_Parametros != null) &&
                    (Obj_DB_DAL.Dt_Parametros.Rows.Count > 0))
                {

                    SqlDbType SQL_db_type = SqlDbType.VarChar;


                    foreach (DataRow dr in Obj_DB_DAL.Dt_Parametros.Rows)
                    {
                        switch (dr[1].ToString())
                        {
                            case "1":
                                SQL_db_type = SqlDbType.Int;
                                break;
                            case "2":
                                SQL_db_type = SqlDbType.Decimal;
                                break;
                            case "3":
                                SQL_db_type = SqlDbType.DateTime;
                                break;
                            case "4":
                                SQL_db_type = SqlDbType.Char;
                                break;
                            case "5":
                                SQL_db_type = SqlDbType.NChar;
                                break;
                            case "6":
                                SQL_db_type = SqlDbType.NVarChar;
                                break;
                            default:
                                SQL_db_type = SqlDbType.VarChar;
                                break;
                        }

                        Obj_DB_DAL.Obj_SQL_DAP.SelectCommand.Parameters.Add(dr[0].ToString().Trim(), SQL_db_type).Value = dr[2].ToString().Trim();
                    }
                }


                #endregion

                Obj_DB_DAL.Obj_SQL_DAP.SelectCommand.CommandType = CommandType.StoredProcedure;

                Obj_DB_DAL.Ds = new DataSet();

                Obj_DB_DAL.Obj_SQL_DAP.Fill(Obj_DB_DAL.Ds);

                Obj_DB_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_DB_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_DB_DAL.Obj_SQL_CNX != null)
                {
                    if (Obj_DB_DAL.Obj_SQL_CNX.State == ConnectionState.Open)
                    {
                        Obj_DB_DAL.Obj_SQL_CNX.Close();
                    }

                    Obj_DB_DAL.Obj_SQL_CNX.Dispose();
                }
            }
        }


        public void ExecNonQuery(ref Cls_BD_DAL Obj_DB_DAL)
        {
            try
            {
                Obj_DB_DAL.sCadena = ConfigurationManager.ConnectionStrings[Obj_DB_DAL.sNombCNXConfig].ToString();

                Obj_DB_DAL.Obj_SQL_CNX = new SqlConnection(Obj_DB_DAL.sCadena);

                if (Obj_DB_DAL.Obj_SQL_CNX.State == ConnectionState.Closed)
                {
                    Obj_DB_DAL.Obj_SQL_CNX.Open();
                }

                Obj_DB_DAL.Obj_SQL_CMD = new SqlCommand(Obj_DB_DAL.sNombSP, Obj_DB_DAL.Obj_SQL_CNX);


                #region AGREGAR PARAMETROS

                if ((Obj_DB_DAL.Dt_Parametros != null) &&
                    (Obj_DB_DAL.Dt_Parametros.Rows.Count > 0))
                {

                    SqlDbType SQL_db_type = SqlDbType.VarChar;


                    foreach (DataRow dr in Obj_DB_DAL.Dt_Parametros.Rows)
                    {
                        switch (dr[1].ToString())
                        {
                            case "1":
                                SQL_db_type = SqlDbType.Int;
                                break;
                            case "2":
                                SQL_db_type = SqlDbType.Decimal;
                                break;
                            case "3":
                                SQL_db_type = SqlDbType.DateTime;
                                break;
                            case "4":
                                SQL_db_type = SqlDbType.Char;
                                break;
                            case "5":
                                SQL_db_type = SqlDbType.NChar;
                                break;
                            case "6":
                                SQL_db_type = SqlDbType.NVarChar;
                                break;
                            default:
                                SQL_db_type = SqlDbType.VarChar;
                                break;
                        }

                        Obj_DB_DAL.Obj_SQL_CMD.Parameters.Add(dr[0].ToString().Trim(), SQL_db_type).Value = dr[2].ToString().Trim();
                    }
                }


                #endregion

                Obj_DB_DAL.Obj_SQL_CMD.CommandType = CommandType.StoredProcedure;


                Obj_DB_DAL.Obj_SQL_CMD.ExecuteNonQuery();

                Obj_DB_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_DB_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_DB_DAL.Obj_SQL_CNX != null)
                {
                    if (Obj_DB_DAL.Obj_SQL_CNX.State == ConnectionState.Open)
                    {
                        Obj_DB_DAL.Obj_SQL_CNX.Close();
                    }

                    Obj_DB_DAL.Obj_SQL_CNX.Dispose();
                }
            }

        }



        public void ExecScalar(ref Cls_BD_DAL Obj_DB_DAL)
        {
            try
            {
                Obj_DB_DAL.sCadena = ConfigurationManager.ConnectionStrings[Obj_DB_DAL.sNombCNXConfig].ToString();

                Obj_DB_DAL.Obj_SQL_CNX = new SqlConnection(Obj_DB_DAL.sCadena);

                if (Obj_DB_DAL.Obj_SQL_CNX.State == ConnectionState.Closed)
                {
                    Obj_DB_DAL.Obj_SQL_CNX.Open();
                }

                Obj_DB_DAL.Obj_SQL_CMD = new SqlCommand(Obj_DB_DAL.sNombSP, Obj_DB_DAL.Obj_SQL_CNX);


                #region AGREGAR PARAMETROS

                if ((Obj_DB_DAL.Dt_Parametros != null) &&
                    (Obj_DB_DAL.Dt_Parametros.Rows.Count > 0))
                {

                    SqlDbType SQL_db_type = SqlDbType.VarChar;


                    foreach (DataRow dr in Obj_DB_DAL.Dt_Parametros.Rows)
                    {
                        switch (dr[1].ToString())
                        {
                            case "1":
                                SQL_db_type = SqlDbType.Int;
                                break;
                            case "2":
                                SQL_db_type = SqlDbType.Decimal;
                                break;
                            case "3":
                                SQL_db_type = SqlDbType.DateTime;
                                break;
                            case "4":
                                SQL_db_type = SqlDbType.Char;
                                break;
                            case "5":
                                SQL_db_type = SqlDbType.NChar;
                                break;
                            case "6":
                                SQL_db_type = SqlDbType.NVarChar;
                                break;
                            default:
                                SQL_db_type = SqlDbType.VarChar;
                                break;
                        }

                        Obj_DB_DAL.Obj_SQL_CMD.Parameters.Add(dr[0].ToString().Trim(), SQL_db_type).Value = dr[2].ToString().Trim();
                    }
                }


                #endregion

                Obj_DB_DAL.Obj_SQL_CMD.CommandType = CommandType.StoredProcedure;


                Obj_DB_DAL.sValorScalar = Obj_DB_DAL.Obj_SQL_CMD.ExecuteScalar().ToString();

                Obj_DB_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_DB_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_DB_DAL.Obj_SQL_CNX != null)
                {
                    if (Obj_DB_DAL.Obj_SQL_CNX.State == ConnectionState.Open)
                    {
                        Obj_DB_DAL.Obj_SQL_CNX.Close();
                    }

                    Obj_DB_DAL.Obj_SQL_CNX.Dispose();
                }
            }
        }



        public void Crear_DT_Param(ref DataTable DT_Parametros)
        {
            DT_Parametros = new DataTable();

            DT_Parametros.Columns.Add("NomParam");
            DT_Parametros.Columns.Add("TipDat");
            DT_Parametros.Columns.Add("Valor");


        }





    }
}
