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
    public class Cls_Contactos_BLL
    {


        public void ListarFiltrarContactos(ref DataSet DS, string sFiltro)
        {
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();




            Obj_BD_DAL.sNombCNXConfig = "WIN_AUT";



            if (sFiltro == string.Empty)
            {
                Obj_BD_DAL.Dt_Parametros = null;
                Obj_BD_DAL.sNombSP = "dbo.PA_CONSULTAR_CONTACTOS";
            }
            else
            {
                Obj_BD_DAL.sNombSP = "dbo.PA_FILTRAR_CONTACTOS";


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



        public void CrearContactos(ref Cls_Contactos_DAL Obj_Contactos_DAL, ref string sMsjError)
        {
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();


            Obj_BD_DAL.sNombCNXConfig = "WIN_AUT";


            Obj_BD_DAL.sNombSP = "dbo.PA_CREAR_CONTACTOS";


            DataTable DT = new DataTable();
            Obj_BD_BLL.Crear_DT_Param(ref DT);


            
            DT.Rows.Add("@Cedula_Cont", "",Obj_Contactos_DAL.sIdContacto);
            DT.Rows.Add("@Nombre", "", Obj_Contactos_DAL.sNombre);
            DT.Rows.Add("@Apellidos", "", Obj_Contactos_DAL.sApellidos);
            DT.Rows.Add("@Direccion", "", Obj_Contactos_DAL.sDireccion);
            DT.Rows.Add("@Telefono", "", Obj_Contactos_DAL.sTelefono);
            DT.Rows.Add("@Correo_Electronico", "", Obj_Contactos_DAL.sCorreo);
            DT.Rows.Add("@Sexo", "4", Obj_Contactos_DAL.cSexo);
            DT.Rows.Add("@Estado", "4", Obj_Contactos_DAL.cEstado);



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
