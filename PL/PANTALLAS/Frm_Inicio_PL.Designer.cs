namespace PL.PANTALLAS
{
    partial class Frm_Inicio_PL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation3 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inicio_PL));
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation4 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.PanelTransition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconRestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.iconMaximizar = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel2 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.MenuVertical = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.PanelMantenimientos = new System.Windows.Forms.Panel();
            this.btnMantTerapia = new System.Windows.Forms.Button();
            this.btnMantNutricion = new System.Windows.Forms.Button();
            this.btnMantEnfermeria = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnTerapia = new System.Windows.Forms.Button();
            this.btnNutricion = new System.Windows.Forms.Button();
            this.btnEnfermeria = new System.Windows.Forms.Button();
            this.PanelAdmin = new System.Windows.Forms.Panel();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnFamilia = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LogoTransition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.PanelMantenimientos.SuspendLayout();
            this.PanelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconRestaurar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.iconMinimizar);
            this.panel2.Controls.Add(this.iconCerrar);
            this.panel2.Controls.Add(this.iconMaximizar);
            this.LogoTransition.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 50);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // iconRestaurar
            // 
            this.iconRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.iconRestaurar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.iconRestaurar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.iconRestaurar.Image = global::PL.Properties.Resources.icon_restaurar;
            this.iconRestaurar.Location = new System.Drawing.Point(970, 12);
            this.iconRestaurar.Name = "iconRestaurar";
            this.iconRestaurar.Size = new System.Drawing.Size(25, 25);
            this.iconRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRestaurar.TabIndex = 4;
            this.iconRestaurar.TabStop = false;
            this.iconRestaurar.Visible = false;
            this.iconRestaurar.Click += new System.EventHandler(this.iconRestaurar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox1.Image = global::PL.Properties.Resources.Mobile_Menu_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.iconMinimizar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.iconMinimizar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.iconMinimizar.Image = global::PL.Properties.Resources.icon_minimizar;
            this.iconMinimizar.Location = new System.Drawing.Point(930, 12);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(25, 25);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 3;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.iconCerrar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.iconCerrar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.iconCerrar.Image = global::PL.Properties.Resources.icon_cerrar2;
            this.iconCerrar.Location = new System.Drawing.Point(1012, 12);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(25, 25);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 1;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // iconMaximizar
            // 
            this.iconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.iconMaximizar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.iconMaximizar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.iconMaximizar.Image = global::PL.Properties.Resources.icon_maximizar;
            this.iconMaximizar.Location = new System.Drawing.Point(970, 12);
            this.iconMaximizar.Name = "iconMaximizar";
            this.iconMaximizar.Size = new System.Drawing.Size(25, 25);
            this.iconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMaximizar.TabIndex = 2;
            this.iconMaximizar.TabStop = false;
            this.iconMaximizar.Click += new System.EventHandler(this.iconMaximizar_Click);
            // 
            // panelChildForm
            // 
            this.LogoTransition.SetDecoration(this.panelChildForm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panelChildForm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 50);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1050, 500);
            this.panelChildForm.TabIndex = 10;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.BorderRadius = 1;
            this.bunifuGradientPanel2.Controls.Add(this.lblCargo);
            this.bunifuGradientPanel2.Controls.Add(this.lbFecha);
            this.bunifuGradientPanel2.Controls.Add(this.lblCorreo);
            this.bunifuGradientPanel2.Controls.Add(this.lblHora);
            this.bunifuGradientPanel2.Controls.Add(this.pictureBox7);
            this.bunifuGradientPanel2.Controls.Add(this.lblNombre);
            this.LogoTransition.SetDecoration(this.bunifuGradientPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuGradientPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Lavender;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Navy;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(250, 550);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1050, 100);
            this.bunifuGradientPanel2.TabIndex = 9;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblCargo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblCargo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(77, 46);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(45, 16);
            this.lblCargo.TabIndex = 12;
            this.lblCargo.Text = "Cargo";
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lbFecha, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lbFecha, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(814, 70);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(224, 20);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblCorreo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblCorreo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(77, 62);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(49, 16);
            this.lblCorreo.TabIndex = 11;
            this.lblCorreo.Text = "Correo";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblHora, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblHora, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(818, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(205, 54);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "21:49:45";
            // 
            // pictureBox7
            // 
            this.PanelTransition.SetDecoration(this.pictureBox7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.pictureBox7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox7.Image = global::PL.Properties.Resources.perfil;
            this.pictureBox7.Location = new System.Drawing.Point(6, 23);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(65, 65);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblNombre, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblNombre, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(77, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(134, 16);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombres y Apellidos";
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.Transparent;
            this.MenuVertical.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuVertical.BackgroundImage")));
            this.MenuVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuVertical.BorderRadius = 1;
            this.MenuVertical.Controls.Add(this.btnSalir);
            this.MenuVertical.Controls.Add(this.PanelMantenimientos);
            this.MenuVertical.Controls.Add(this.btnMantenimiento);
            this.MenuVertical.Controls.Add(this.btnTerapia);
            this.MenuVertical.Controls.Add(this.btnNutricion);
            this.MenuVertical.Controls.Add(this.btnEnfermeria);
            this.MenuVertical.Controls.Add(this.PanelAdmin);
            this.MenuVertical.Controls.Add(this.btnAdmin);
            this.MenuVertical.Controls.Add(this.Logo);
            this.LogoTransition.SetDecoration(this.MenuVertical, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelTransition.SetDecoration(this.MenuVertical, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.GradientBottomLeft = System.Drawing.Color.Navy;
            this.MenuVertical.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MenuVertical.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.MenuVertical.GradientTopRight = System.Drawing.Color.Lavender;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Quality = 10;
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PL.Properties.Resources.Power_Log_Off;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelTransition.SetDecoration(this.btnSalir, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnSalir, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(12, 604);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 36);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PanelMantenimientos
            // 
            this.PanelMantenimientos.Controls.Add(this.btnMantTerapia);
            this.PanelMantenimientos.Controls.Add(this.btnMantNutricion);
            this.PanelMantenimientos.Controls.Add(this.btnMantEnfermeria);
            this.LogoTransition.SetDecoration(this.PanelMantenimientos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelTransition.SetDecoration(this.PanelMantenimientos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelMantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMantenimientos.Location = new System.Drawing.Point(0, 498);
            this.PanelMantenimientos.Name = "PanelMantenimientos";
            this.PanelMantenimientos.Size = new System.Drawing.Size(250, 125);
            this.PanelMantenimientos.TabIndex = 8;
            // 
            // btnMantTerapia
            // 
            this.btnMantTerapia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnMantTerapia, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMantTerapia, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnMantTerapia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantTerapia.FlatAppearance.BorderSize = 0;
            this.btnMantTerapia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMantTerapia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantTerapia.ForeColor = System.Drawing.Color.White;
            this.btnMantTerapia.Location = new System.Drawing.Point(0, 80);
            this.btnMantTerapia.Name = "btnMantTerapia";
            this.btnMantTerapia.Size = new System.Drawing.Size(250, 40);
            this.btnMantTerapia.TabIndex = 13;
            this.btnMantTerapia.Text = "TERAPÍA";
            this.btnMantTerapia.UseVisualStyleBackColor = true;
            this.btnMantTerapia.Click += new System.EventHandler(this.btnMantTerapia_Click);
            // 
            // btnMantNutricion
            // 
            this.btnMantNutricion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnMantNutricion, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMantNutricion, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnMantNutricion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantNutricion.FlatAppearance.BorderSize = 0;
            this.btnMantNutricion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMantNutricion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantNutricion.ForeColor = System.Drawing.Color.White;
            this.btnMantNutricion.Location = new System.Drawing.Point(0, 40);
            this.btnMantNutricion.Name = "btnMantNutricion";
            this.btnMantNutricion.Size = new System.Drawing.Size(250, 40);
            this.btnMantNutricion.TabIndex = 12;
            this.btnMantNutricion.Text = "NUTRICIÓN";
            this.btnMantNutricion.UseVisualStyleBackColor = true;
            this.btnMantNutricion.Click += new System.EventHandler(this.btnMantNutricion_Click);
            // 
            // btnMantEnfermeria
            // 
            this.btnMantEnfermeria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnMantEnfermeria, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMantEnfermeria, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnMantEnfermeria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantEnfermeria.FlatAppearance.BorderSize = 0;
            this.btnMantEnfermeria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMantEnfermeria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantEnfermeria.ForeColor = System.Drawing.Color.White;
            this.btnMantEnfermeria.Location = new System.Drawing.Point(0, 0);
            this.btnMantEnfermeria.Name = "btnMantEnfermeria";
            this.btnMantEnfermeria.Size = new System.Drawing.Size(250, 40);
            this.btnMantEnfermeria.TabIndex = 11;
            this.btnMantEnfermeria.Text = "ENFERMERÍA";
            this.btnMantEnfermeria.UseVisualStyleBackColor = true;
            this.btnMantEnfermeria.Click += new System.EventHandler(this.btnMantEnfermeria_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnMantenimiento, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMantenimiento, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnMantenimiento.ForeColor = System.Drawing.Color.White;
            this.btnMantenimiento.Image = global::PL.Properties.Resources.gear_2_32;
            this.btnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimiento.Location = new System.Drawing.Point(0, 453);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btnMantenimiento.Size = new System.Drawing.Size(250, 45);
            this.btnMantenimiento.TabIndex = 7;
            this.btnMantenimiento.Text = "Mantenimientos";
            this.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // btnTerapia
            // 
            this.btnTerapia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnTerapia, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnTerapia, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnTerapia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTerapia.FlatAppearance.BorderSize = 0;
            this.btnTerapia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTerapia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerapia.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnTerapia.ForeColor = System.Drawing.Color.White;
            this.btnTerapia.Image = global::PL.Properties.Resources.running_man_32;
            this.btnTerapia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerapia.Location = new System.Drawing.Point(0, 408);
            this.btnTerapia.Name = "btnTerapia";
            this.btnTerapia.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btnTerapia.Size = new System.Drawing.Size(250, 45);
            this.btnTerapia.TabIndex = 6;
            this.btnTerapia.Text = "Terapía";
            this.btnTerapia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerapia.UseVisualStyleBackColor = true;
            this.btnTerapia.Click += new System.EventHandler(this.btnTerapia_Click);
            // 
            // btnNutricion
            // 
            this.btnNutricion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnNutricion, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnNutricion, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnNutricion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNutricion.FlatAppearance.BorderSize = 0;
            this.btnNutricion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNutricion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNutricion.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnNutricion.ForeColor = System.Drawing.Color.White;
            this.btnNutricion.Image = global::PL.Properties.Resources.viadeo_32;
            this.btnNutricion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNutricion.Location = new System.Drawing.Point(0, 363);
            this.btnNutricion.Name = "btnNutricion";
            this.btnNutricion.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btnNutricion.Size = new System.Drawing.Size(250, 45);
            this.btnNutricion.TabIndex = 5;
            this.btnNutricion.Text = "Nutrición";
            this.btnNutricion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNutricion.UseVisualStyleBackColor = true;
            this.btnNutricion.Click += new System.EventHandler(this.btnNutricion_Click);
            // 
            // btnEnfermeria
            // 
            this.btnEnfermeria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnEnfermeria, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnEnfermeria, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnEnfermeria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnfermeria.FlatAppearance.BorderSize = 0;
            this.btnEnfermeria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEnfermeria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnfermeria.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnEnfermeria.ForeColor = System.Drawing.Color.White;
            this.btnEnfermeria.Image = global::PL.Properties.Resources.nurse_32;
            this.btnEnfermeria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnfermeria.Location = new System.Drawing.Point(0, 318);
            this.btnEnfermeria.Name = "btnEnfermeria";
            this.btnEnfermeria.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btnEnfermeria.Size = new System.Drawing.Size(250, 45);
            this.btnEnfermeria.TabIndex = 4;
            this.btnEnfermeria.Text = "Enfermería";
            this.btnEnfermeria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnfermeria.UseVisualStyleBackColor = true;
            this.btnEnfermeria.Click += new System.EventHandler(this.btnEnfermeria_Click);
            // 
            // PanelAdmin
            // 
            this.PanelAdmin.Controls.Add(this.btnPersonal);
            this.PanelAdmin.Controls.Add(this.btnFamilia);
            this.PanelAdmin.Controls.Add(this.btnPacientes);
            this.LogoTransition.SetDecoration(this.PanelAdmin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelTransition.SetDecoration(this.PanelAdmin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelAdmin.Location = new System.Drawing.Point(0, 183);
            this.PanelAdmin.Name = "PanelAdmin";
            this.PanelAdmin.Size = new System.Drawing.Size(250, 135);
            this.PanelAdmin.TabIndex = 3;
            // 
            // btnPersonal
            // 
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnPersonal, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnPersonal, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.ForeColor = System.Drawing.Color.White;
            this.btnPersonal.Location = new System.Drawing.Point(0, 80);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(250, 40);
            this.btnPersonal.TabIndex = 5;
            this.btnPersonal.Text = "PERSONAL";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnFamilia
            // 
            this.btnFamilia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnFamilia, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnFamilia, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnFamilia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFamilia.FlatAppearance.BorderSize = 0;
            this.btnFamilia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamilia.ForeColor = System.Drawing.Color.White;
            this.btnFamilia.Location = new System.Drawing.Point(0, 40);
            this.btnFamilia.Name = "btnFamilia";
            this.btnFamilia.Size = new System.Drawing.Size(250, 40);
            this.btnFamilia.TabIndex = 4;
            this.btnFamilia.Text = "FAMILIARES";
            this.btnFamilia.UseVisualStyleBackColor = true;
            this.btnFamilia.Click += new System.EventHandler(this.btnFamilia_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnPacientes, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnPacientes, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.Location = new System.Drawing.Point(0, 0);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(250, 40);
            this.btnPacientes.TabIndex = 3;
            this.btnPacientes.Text = "PACIENTES";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnAdmin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnAdmin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = global::PL.Properties.Resources.clientes;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 138);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(8, 5, 5, 0);
            this.btnAdmin.Size = new System.Drawing.Size(250, 45);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Administración";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelTransition.SetDecoration(this.Logo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Logo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Image = global::PL.Properties.Resources.Residencia;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Logo.Size = new System.Drawing.Size(250, 138);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Mosaic;
            this.LogoTransition.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 20;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation4;
            // 
            // Frm_Inicio_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuVertical);
            this.PanelTransition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Inicio_PL";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Residencia Geriatrica Nuestra Señora de los Angeles";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.PanelMantenimientos.ResumeLayout(false);
            this.PanelAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.PictureBox iconMaximizar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.PictureBox iconRestaurar;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmFechaHora;
        private Bunifu.UI.WinForms.BunifuTransition PanelTransition;
        private Bunifu.UI.WinForms.BunifuTransition LogoTransition;
        private Bunifu.UI.WinForms.BunifuGradientPanel MenuVertical;
        private System.Windows.Forms.Panel PanelMantenimientos;
        private System.Windows.Forms.Button btnMantTerapia;
        private System.Windows.Forms.Button btnMantNutricion;
        private System.Windows.Forms.Button btnMantEnfermeria;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnTerapia;
        private System.Windows.Forms.Button btnNutricion;
        private System.Windows.Forms.Button btnEnfermeria;
        private System.Windows.Forms.Panel PanelAdmin;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnFamilia;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCargo;
    }
}