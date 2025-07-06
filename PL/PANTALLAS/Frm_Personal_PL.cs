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
    public partial class Frm_Personal_PL : Form
    {

        Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
        CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();

        Cls_Personal_DAL Obj_Personal_DAL = new Cls_Personal_DAL();
        Cls_Personal_BLL Obj_Personal_BLL = new Cls_Personal_BLL();

        public Frm_Personal_PL()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Personal_PL_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        private void CargarDatos()
        {
            Cls_Personal_BLL Obj_Personal_BLL = new Cls_Personal_BLL();



            DataSet DS = new DataSet();

            Obj_Personal_BLL.ListarFiltrarPersonal(ref DS, txtFiltro.Text.Trim());

            if (DS != null)
            {

                dgvPersonal.DataSource = null;
                dgvPersonal.DataSource = DS.Tables[0];
            }

            //lblTotal.Text = string.Format("Total Registros: {0}", this.dgv_Casos.RowCount);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_Crear_Personal_PL pantalla = new Frm_Crear_Personal_PL();
            pantalla.ShowDialog();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
