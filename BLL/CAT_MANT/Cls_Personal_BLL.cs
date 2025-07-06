using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;
using DAL.CAT_MANT;
using System.Data;
using BLL.BD;

namespace BLL.CAT_MANT
{
    public class Cls_Personal_BLL
    {

        public void ListarFiltrarPersonal(ref DataSet DS, string sFiltro)
        {
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();




            Obj_BD_DAL.sNombCNXConfig = "WIN_AUT";



            if (sFiltro == string.Empty)
            {
                Obj_BD_DAL.Dt_Parametros = null;
                Obj_BD_DAL.sNombSP = "dbo.PA_CONSULTAR_PERSONAL";
            }
            else
            {
                Obj_BD_DAL.sNombSP = "dbo.PA_FILTRAR_PERSONAL";


                DataTable DT = new DataTable();
                Obj_BD_BLL.Crear_DT_Param(ref DT);


                DT.Rows.Add("@Nombre", "", sFiltro);


                Obj_BD_DAL.Dt_Parametros = DT;
            }


            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);


            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                DS = Obj_BD_DAL.Ds;
            }
            else
            {
                DS = null;
            }
        }



        public void CrearPersonal(ref Cls_Personal_DAL Obj_Personal_DAL, ref string sMsjError)
        {
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();


            Obj_BD_DAL.sNombCNXConfig = "WIN_AUT";


            Obj_BD_DAL.sNombSP = "dbo.PA_CREAR_PERSONAL";


            DataTable DT = new DataTable();
            Obj_BD_BLL.Crear_DT_Param(ref DT);



            DT.Rows.Add("@Cedula_Per", "", Obj_Personal_DAL.sIdPersonal);
            DT.Rows.Add("@Nombre", "", Obj_Personal_DAL.sNombre);
            DT.Rows.Add("@Apellidos", "", Obj_Personal_DAL.sApellidos);
            DT.Rows.Add("@Direccion", "", Obj_Personal_DAL.sDireccion);
            DT.Rows.Add("@Telefono", "", Obj_Personal_DAL.sTelefono);
            DT.Rows.Add("@Correo_Electronico", "", Obj_Personal_DAL.sCorreo);
            DT.Rows.Add("@Sexo", "4", Obj_Personal_DAL.cSexo);
            DT.Rows.Add("@Estado", "4", Obj_Personal_DAL.cEstado);
            DT.Rows.Add("@Password", "", Obj_Personal_DAL.sPassword);
            DT.Rows.Add("@Cargo", "", Obj_Personal_DAL.sCargo);


            Obj_BD_DAL.Dt_Parametros = DT;

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                //Obj_Casos_DAL.cBandera = 'I';
            }
            else
            {
                sMsjError = Obj_BD_DAL.sMsjError;

            }

        }

    }
}
