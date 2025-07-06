using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DAL.BD;
using DAL.CAT_MANT;
using BLL.BD;
using BLL.CAT_MANT;
using Common.Cache;


namespace PL.PANTALLAS
{

       public partial class Frm_Inicio_PL : Form
    {

        Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
        CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();

        Cls_Pacientes_DAL Obj_Pacientes_DAL = new Cls_Pacientes_DAL();
        Cls_Pacientes_BLL Obj_Pacientes_BLL = new Cls_Pacientes_BLL();


        public Frm_Inicio_PL()
        {
            InitializeComponent();
            customizeDesign();
            LoadUserData();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MenuVertical.Width == 90)
            {
                MenuVertical.Visible = false;
                MenuVertical.Width = 250;             
                PanelTransition.ShowSync(MenuVertical);
                btnAdmin.Text = "Administración";
                btnEnfermeria.Text = "Enfermería";
                btnNutricion.Text = "Nutrición";
                btnTerapia.Text = "Terapia";
                btnMantenimiento.Text = "Mantenimientos";
                //MenuVertical.Width = 83;
                //PanelTransition.ShowSync(MenuVertical);
                //LogoTransition.ShowSync(Logo);
            }
            else
            {
               
                MenuVertical.Visible = false;
                MenuVertical.Width = 90;
                PanelTransition.ShowSync(MenuVertical);
                btnAdmin.Text = string.Empty;
                btnEnfermeria.Text = string.Empty;
                btnNutricion.Text = string.Empty;
                btnTerapia.Text = string.Empty;
                btnMantenimiento.Text = string.Empty;



                //MenuVertical.Width = 250;
                //LogoTransition.ShowSync(Logo);
                //PanelTransition.ShowSync(MenuVertical);
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Esta segur@ de cerrar la aplicación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        int LX, LY;
        int sw, sh;

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(sw,sh);
            this.Location = new Point(LX,LY);
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }

        private void AbrirFormInPanel(object formhijo)
        {
            //if (this.panel1.Controls.Count > 0)
            //    this.panel1.Controls.RemoveAt(0);
            //Form fh = formhijo as Form;
            //fh.TopLevel = false;
            //fh.Dock = DockStyle.Fill;
            //this.panel1.Controls.Add(fh);
            //fh.Show();
        }

             
      

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }


        private void customizeDesign()
        {
            PanelAdmin.Visible = false;
            PanelMantenimientos.Visible = false;
        }

        private void hideSubMenu()
        {
            if(PanelAdmin.Visible == true)
            {
                PanelAdmin.Visible = false;
            }
            if (PanelMantenimientos.Visible ==true)
            {
                PanelMantenimientos.Visible = false;
            }
        }

           

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            showSubMenu(PanelAdmin);


            //AbrirFormInPanel(new Frm_Admin_PL());
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            
            openChildForm(new Frm_Admin_PL());
            //AbrirFormInPanel(new Frm_Admin_PL());
            hideSubMenu();
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Contactos_PL());
            hideSubMenu();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelMantenimientos);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Personal_PL());
            hideSubMenu();
        }

        private void btnEnfermeria_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Enfermeria_PL());
            hideSubMenu();
        }

        private void btnNutricion_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Nutricion_PL());
            hideSubMenu();
        }

        private void btnTerapia_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Terapia_PL());
            hideSubMenu();
        }

        private void btnMantEnfermeria_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnMantNutricion_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnMantTerapia_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

       

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta segur@ de cerrar sesión?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                this.Close();
            }
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)            
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
        }

        private void LoadUserData()
        {
            lblNombre.Text = UserLoginCache.Nombre+" "+UserLoginCache.Apellidos;
            //lblApellidos.Text = UserLoginCache.Apellidos;
            lblCorreo.Text = UserLoginCache.Correo;
            lblCargo.Text = UserLoginCache.Cargo;
        }





    }
}
