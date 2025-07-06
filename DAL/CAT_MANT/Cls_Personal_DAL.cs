using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CAT_MANT
{
    public class Cls_Personal_DAL
    {

        private string _sNombre, _sApellidos, _sIdPersonal, _sDireccion, _sTelefono, _sCorreo,_sPassword;
        private string _sCargo;


        private char _cEstado, _cSexo;

        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sApellidos { get => _sApellidos; set => _sApellidos = value; }
        public string sIdPersonal { get => _sIdPersonal; set => _sIdPersonal = value; }
        public string sDireccion { get => _sDireccion; set => _sDireccion = value; }
        public string sTelefono { get => _sTelefono; set => _sTelefono = value; }
        public string sCorreo { get => _sCorreo; set => _sCorreo = value; }
        public string sPassword { get => _sPassword; set => _sPassword = value; }
        public char cEstado { get => _cEstado; set => _cEstado = value; }
        public char cSexo { get => _cSexo; set => _cSexo = value; }
        public string sCargo { get => _sCargo; set => _sCargo = value; }
    }
}
