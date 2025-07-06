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
    public partial class Frm_Crear_Personal_PL : Form
    {

        Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
        CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();

        Cls_Personal_DAL Obj_Personal_DAL = new Cls_Personal_DAL();
        Cls_Personal_BLL Obj_Personal_BLL = new Cls_Personal_BLL();

        string sMsjError = string.Empty;



        public Frm_Crear_Personal_PL()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtCedula.Text == string.Empty || cbHombre.Checked == false & cbMujer.Checked == false || txtCorreo.Text == string.Empty || txtDireccion.Text == string.Empty || txtTelefono.Text == string.Empty || txtPassword.Text==string.Empty)
            {
                MessageBox.Show("Todos los campos son necesarios para crear el caso!!!", "Atención!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {
                Obj_Personal_DAL.sNombre = txtNombre.Text.Trim();
                Obj_Personal_DAL.sApellidos = txtApellido.Text.Trim();
                Obj_Personal_DAL.sIdPersonal = txtCedula.Text.Trim();
                Obj_Personal_DAL.sDireccion = txtDireccion.Text.Trim();
                Obj_Personal_DAL.sTelefono = txtTelefono.Text.Trim();
                Obj_Personal_DAL.sCorreo = txtCorreo.Text.Trim();
                Obj_Personal_DAL.sCargo = txtCargo.Text.Trim();

                if (cbHombre.Checked == true)
                {
                    cbMujer.Checked = false;
                    Obj_Personal_DAL.cSexo = 'M';
                }
                else
                {
                    cbHombre.Checked = false;
                    Obj_Personal_DAL.cSexo = 'F';
                }

                Obj_Personal_DAL.cEstado = 'A';

                Obj_Personal_DAL.sPassword = txtPassword.Text.Trim();


                Obj_Personal_BLL.CrearPersonal(ref Obj_Personal_DAL, ref sMsjError);


                if (sMsjError == string.Empty)
                {
                    MessageBox.Show("SE HA INSERTADO CORRECTAMENTE EL NUEVO PERSONAL");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("SE PRESENTÓ UN ERROR A LA HORA DE INSERTAR EL NUEVO PERSONAL, VERIFIQUE LA INFORMACIÓN. [" + sMsjError + "]");
                }
            }
        }
    }
}
