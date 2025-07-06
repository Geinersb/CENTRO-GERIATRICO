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
    public class Cls_Pacientes_BLL
    {
        public void ListarFiltrarPacientes(ref DataSet DS, string sFiltro)
        {
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();
           
          


            Obj_BD_DAL.sNombCNXConfig = "WIN_AUT";



            if (sFiltro == string.Empty)
            {
                Obj_BD_DAL.Dt_Parametros = null;
                Obj_BD_DAL.sNombSP = "dbo.PA_CONSULTAR_PACIENTES";
            }
            else
            {
                Obj_BD_DAL.sNombSP = "dbo.PA_FILTRAR_PACIENTES";


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



        public void CrearPacientes(ref Cls_Pacientes_DAL Obj_Pacientes_DAL, ref string sMsjError)
        {
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();


            Obj_BD_DAL.sNombCNXConfig = "WIN_AUT";


            Obj_BD_DAL.sNombSP = "dbo.PA_CREAR_PACIENTES";


            DataTable DT = new DataTable();
            Obj_BD_BLL.Crear_DT_Param(ref DT);


            DT.Rows.Add("@Cedula_Pac", "", Obj_Pacientes_DAL.sIdPaciente);
            DT.Rows.Add("@Cedula_Cont", "", Obj_Pacientes_DAL.sIdContacto);
            DT.Rows.Add("@Nombre", "", Obj_Pacientes_DAL.sNombre);
            DT.Rows.Add("@Apellidos", "", Obj_Pacientes_DAL.sApellidos);
            DT.Rows.Add("@Fecha_Nacimiento", "3",Obj_Pacientes_DAL.DFecha);
            DT.Rows.Add("@Tipo_Sangre", "", Obj_Pacientes_DAL.sTipoSangre);
            DT.Rows.Add("@Sexo", "4", Obj_Pacientes_DAL.cSexo);
            DT.Rows.Add("@Estado", "4", Obj_Pacientes_DAL.cEstado);



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




        public void ModificarPacientes(ref Cls_Pacientes_DAL Obj_Pacientes_DAL, ref string sMsjError)
        {
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();


            Obj_BD_DAL.sNombCNXConfig = "WIN_AUT";


            Obj_BD_DAL.sNombSP = "dbo.PA_MODIFICAR_PACIENTES";


            DataTable DT = new DataTable();
            Obj_BD_BLL.Crear_DT_Param(ref DT);


            DT.Rows.Add("@Cedula_Pac", "", Obj_Pacientes_DAL.sIdPaciente);
            DT.Rows.Add("@Nombre", "", Obj_Pacientes_DAL.sNombre);            
            DT.Rows.Add("@Cedula_Cont", "", Obj_Pacientes_DAL.sIdContacto);          
            DT.Rows.Add("@Apellidos", "", Obj_Pacientes_DAL.sApellidos);
            DT.Rows.Add("@Fecha_Nacimiento", "3", Obj_Pacientes_DAL.DFecha);
            DT.Rows.Add("@Tipo_Sangre", "", Obj_Pacientes_DAL.sTipoSangre);
            DT.Rows.Add("@Sexo", "4", Obj_Pacientes_DAL.cSexo);
            DT.Rows.Add("@Estado", "4", Obj_Pacientes_DAL.cEstado);



            Obj_BD_DAL.Dt_Parametros = DT;

            Obj_BD_BLL.ExecNonQuery(ref Obj_BD_DAL);


            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                Obj_Pacientes_DAL.cBandera = 'U';
            }
            else
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Pacientes_DAL.cBandera = 'I';
            }



        }



    }
}
