using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.BD;
using DAL.CAT_MANT;
using BLL.BD;
using BLL.CAT_MANT;

namespace PL.PANTALLAS
{
    public partial class Frm_Crear_Contactos_PL : Form
    {

        Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
        CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();

        Cls_Contactos_DAL Obj_Contactos_DAL = new Cls_Contactos_DAL();
        Cls_Contactos_BLL Obj_Contactos_BLL = new Cls_Contactos_BLL();

        string sMsjError = string.Empty;

        public Frm_Crear_Contactos_PL()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtCedula.Text == string.Empty ||  cbHombre.Checked == false & cbMujer.Checked == false || txtCorreo.Text==string.Empty || txtDireccion.Text==string.Empty || txtTelefono.Text==string.Empty)
            {
                MessageBox.Show("Todos los campos son necesarios para crear el caso!!!", "Atención!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {
                Obj_Contactos_DAL.sNombre = txtNombre.Text.Trim();
                Obj_Contactos_DAL.sApellidos = txtApellido.Text.Trim();
                Obj_Contactos_DAL.sIdContacto = txtCedula.Text.Trim();
                Obj_Contactos_DAL.sDireccion = txtDireccion.Text.Trim();
                Obj_Contactos_DAL.sTelefono = txtTelefono.Text.Trim();
                Obj_Contactos_DAL.sCorreo = txtCorreo.Text.Trim();                

                if (cbHombre.Checked == true)
                {
                    cbMujer.Checked = false;
                    Obj_Contactos_DAL.cSexo = 'M';
                }
                else
                {
                    cbHombre.Checked = false;
                    Obj_Contactos_DAL.cSexo = 'F';
                }

                Obj_Contactos_DAL.cEstado = 'A';
               

                Obj_Contactos_BLL.CrearContactos(ref Obj_Contactos_DAL, ref sMsjError);


                if (sMsjError == string.Empty)
                {
                    MessageBox.Show("SE HA INSERTADO CORRECTAMENTE EL NUEVO CONTACTOS");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("SE PRESENTÓ UN ERROR A LA HORA DE INSERTAR EL NUEVO CONTACTO, VERIFIQUE LA INFORMACIÓN. [" + sMsjError + "]");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

