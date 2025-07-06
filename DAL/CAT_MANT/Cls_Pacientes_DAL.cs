using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CAT_MANT
{
    public class Cls_Pacientes_DAL
    {
       
     
        private string _sNombre, _sApellidos,_sIdContacto, _sIdPaciente,_sTipoSangre;

        private DateTime dFecha;

        private char _cBandera;

        private char _cEstado, _cSexo;

        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sApellidos { get => _sApellidos; set => _sApellidos = value; }
        public string sIdContacto { get => _sIdContacto; set => _sIdContacto = value; }
        public string sIdPaciente { get => _sIdPaciente; set => _sIdPaciente = value; }
        public string sTipoSangre { get => _sTipoSangre; set => _sTipoSangre = value; }
       
        public char cEstado { get => _cEstado; set => _cEstado = value; }
        public char cSexo { get => _cSexo; set => _cSexo = value; }
        public DateTime DFecha { get => dFecha; set => dFecha = value; }
        public char cBandera { get => _cBandera; set => _cBandera = value; }
    }
}
