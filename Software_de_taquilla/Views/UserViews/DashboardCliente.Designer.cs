namespace Software_de_taquilla.Views.UserViews
{
    partial class DashboardCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardCliente));
            PanelMenu = new Panel();
            PanelDatos = new Panel();
            label1 = new Label();
            PctPerfil = new PictureBox();
            lblPerfil = new Label();
            lblEstado = new Label();
            btnInicio = new Button();
            btnCartelera = new Button();
            btnCobros = new Button();
            btnMenuAyuda = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            PanelMenu.SuspendLayout();
            PanelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PctPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(12, 62, 85);
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(btnSalir);
            PanelMenu.Controls.Add(btnMenuAyuda);
            PanelMenu.Controls.Add(btnCobros);
            PanelMenu.Controls.Add(btnCartelera);
            PanelMenu.Controls.Add(btnInicio);
            PanelMenu.Controls.Add(PanelDatos);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(250, 411);
            PanelMenu.TabIndex = 0;
            // 
            // PanelDatos
            // 
            PanelDatos.Controls.Add(lblEstado);
            PanelDatos.Controls.Add(lblPerfil);
            PanelDatos.Controls.Add(PctPerfil);
            PanelDatos.Controls.Add(label1);
            PanelDatos.Dock = DockStyle.Top;
            PanelDatos.Location = new Point(0, 0);
            PanelDatos.Name = "PanelDatos";
            PanelDatos.Size = new Size(250, 139);
            PanelDatos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(49, 26);
            label1.Name = "label1";
            label1.Size = new Size(152, 19);
            label1.TabIndex = 0;
            label1.Text = "MACRO CINEMA";
            label1.Click += label1_Click;
            // 
            // PctPerfil
            // 
            PctPerfil.Location = new Point(49, 65);
            PctPerfil.Name = "PctPerfil";
            PctPerfil.Size = new Size(66, 50);
            PctPerfil.TabIndex = 1;
            PctPerfil.TabStop = false;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerfil.ForeColor = SystemColors.Control;
            lblPerfil.Location = new Point(124, 74);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(44, 16);
            lblPerfil.TabIndex = 2;
            lblPerfil.Text = "Usuario";
            lblPerfil.Click += label2_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.ForeColor = Color.FromArgb(43, 105, 130);
            lblEstado.Location = new Point(124, 99);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(39, 16);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado";
            lblEstado.Click += label3_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 171, 218);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 171, 218);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.ForeColor = SystemColors.Control;
            btnInicio.Location = new Point(0, 139);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(250, 45);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnCartelera
            // 
            btnCartelera.Dock = DockStyle.Top;
            btnCartelera.FlatAppearance.BorderSize = 0;
            btnCartelera.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 171, 218);
            btnCartelera.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 171, 218);
            btnCartelera.FlatStyle = FlatStyle.Flat;
            btnCartelera.ForeColor = SystemColors.Control;
            btnCartelera.Location = new Point(0, 184);
            btnCartelera.Name = "btnCartelera";
            btnCartelera.Size = new Size(250, 45);
            btnCartelera.TabIndex = 3;
            btnCartelera.Text = "Cartelera";
            btnCartelera.UseVisualStyleBackColor = true;
            // 
            // btnCobros
            // 
            btnCobros.Dock = DockStyle.Top;
            btnCobros.FlatAppearance.BorderSize = 0;
            btnCobros.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 171, 218);
            btnCobros.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 171, 218);
            btnCobros.FlatStyle = FlatStyle.Flat;
            btnCobros.ForeColor = SystemColors.Control;
            btnCobros.Location = new Point(0, 229);
            btnCobros.Name = "btnCobros";
            btnCobros.Size = new Size(250, 45);
            btnCobros.TabIndex = 4;
            btnCobros.Text = "Cobros";
            btnCobros.UseVisualStyleBackColor = true;
            // 
            // btnMenuAyuda
            // 
            btnMenuAyuda.Dock = DockStyle.Top;
            btnMenuAyuda.FlatAppearance.BorderSize = 0;
            btnMenuAyuda.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 171, 218);
            btnMenuAyuda.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 171, 218);
            btnMenuAyuda.FlatStyle = FlatStyle.Flat;
            btnMenuAyuda.ForeColor = SystemColors.Control;
            btnMenuAyuda.Location = new Point(0, 274);
            btnMenuAyuda.Name = "btnMenuAyuda";
            btnMenuAyuda.Size = new Size(250, 45);
            btnMenuAyuda.TabIndex = 5;
            btnMenuAyuda.Text = "Menú de ayuda";
            btnMenuAyuda.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = SystemColors.Control;
            btnSalir.Location = new Point(157, 356);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 43);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // DashboardCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(PanelMenu);
            Name = "DashboardCliente";
            Text = "DashboardCliente";
            PanelMenu.ResumeLayout(false);
            PanelDatos.ResumeLayout(false);
            PanelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PctPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Panel PanelDatos;
        private Label label1;
        private PictureBox PctPerfil;
        private Label lblPerfil;
        private Label lblEstado;
        private Button btnInicio;
        private Button btnSalir;
        private Button btnMenuAyuda;
        private Button btnCobros;
        private Button btnCartelera;
        private PictureBox pictureBox1;
    }
}