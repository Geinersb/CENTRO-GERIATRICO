using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CAT_MANT
{
    public class Cls_Contactos_DAL
    {


        private string _sNombre, _sApellidos, _sIdContacto, _sDireccion, _sTelefono, _sCorreo;


        private char _cEstado, _cSexo;

        public string sNombre { get => _sNombre; set => _sNombre = value; }
        public string sApellidos { get => _sApellidos; set => _sApellidos = value; }
        public string sIdContacto { get => _sIdContacto; set => _sIdContacto = value; }
        public string sDireccion { get => _sDireccion; set => _sDireccion = value; }
        public string sTelefono { get => _sTelefono; set => _sTelefono = value; }
        public string sCorreo { get => _sCorreo; set => _sCorreo = value; }
        public char cEstado { get => _cEstado; set => _cEstado = value; }
        public char cSexo { get => _cSexo; set => _cSexo = value; }

    }
}
