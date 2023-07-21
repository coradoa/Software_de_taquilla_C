namespace Software_de_taquilla.Views.AdminViews
{
    partial class DashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMenuAyuda = new System.Windows.Forms.Button();
            this.btnCartelera = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.PanelDatos = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.PctPerfil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            this.PanelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoScroll = true;
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.PanelMenu.Controls.Add(this.btnSalir);
            this.PanelMenu.Controls.Add(this.btnMenuAyuda);
            this.PanelMenu.Controls.Add(this.btnCartelera);
            this.PanelMenu.Controls.Add(this.btnInicio);
            this.PanelMenu.Controls.Add(this.PanelDatos);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(273, 553);
            this.PanelMenu.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(126, 446);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnMenuAyuda
            // 
            this.btnMenuAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuAyuda.FlatAppearance.BorderSize = 0;
            this.btnMenuAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(171)))), ((int)(((byte)(218)))));
            this.btnMenuAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(171)))), ((int)(((byte)(218)))));
            this.btnMenuAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAyuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuAyuda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenuAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuAyuda.Image")));
            this.btnMenuAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAyuda.Location = new System.Drawing.Point(0, 305);
            this.btnMenuAyuda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMenuAyuda.Name = "btnMenuAyuda";
            this.btnMenuAyuda.Size = new System.Drawing.Size(273, 60);
            this.btnMenuAyuda.TabIndex = 5;
            this.btnMenuAyuda.Text = "Menú de ayuda";
            this.btnMenuAyuda.UseVisualStyleBackColor = true;
            // 
            // btnCartelera
            // 
            this.btnCartelera.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCartelera.FlatAppearance.BorderSize = 0;
            this.btnCartelera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(171)))), ((int)(((byte)(218)))));
            this.btnCartelera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(171)))), ((int)(((byte)(218)))));
            this.btnCartelera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartelera.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCartelera.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCartelera.Image = global::Software_de_taquilla.Properties.Resources.report2;
            this.btnCartelera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartelera.Location = new System.Drawing.Point(0, 245);
            this.btnCartelera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCartelera.Name = "btnCartelera";
            this.btnCartelera.Size = new System.Drawing.Size(273, 60);
            this.btnCartelera.TabIndex = 3;
            this.btnCartelera.Text = "Reportes";
            this.btnCartelera.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(171)))), ((int)(((byte)(218)))));
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(171)))), ((int)(((byte)(218)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 185);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(273, 60);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // PanelDatos
            // 
            this.PanelDatos.Controls.Add(this.lblEstado);
            this.PanelDatos.Controls.Add(this.lblPerfil);
            this.PanelDatos.Controls.Add(this.PctPerfil);
            this.PanelDatos.Controls.Add(this.label1);
            this.PanelDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDatos.Location = new System.Drawing.Point(0, 0);
            this.PanelDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelDatos.Name = "PanelDatos";
            this.PanelDatos.Size = new System.Drawing.Size(273, 185);
            this.PanelDatos.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(130)))));
            this.lblEstado.Location = new System.Drawing.Point(142, 132);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 19);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPerfil.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPerfil.Location = new System.Drawing.Point(142, 99);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(107, 19);
            this.lblPerfil.TabIndex = 2;
            this.lblPerfil.Text = "Administrador";
            // 
            // PctPerfil
            // 
            this.PctPerfil.Location = new System.Drawing.Point(56, 87);
            this.PctPerfil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PctPerfil.Name = "PctPerfil";
            this.PctPerfil.Size = new System.Drawing.Size(75, 76);
            this.PctPerfil.TabIndex = 1;
            this.PctPerfil.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MACRO CINEMA";
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 553);
            this.Controls.Add(this.PanelMenu);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "DashboardAdmin";
            this.Text = "DashboardAdmin";
            this.PanelMenu.ResumeLayout(false);
            this.PanelDatos.ResumeLayout(false);
            this.PanelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelMenu;
        private Button btnSalir;
        private Button btnMenuAyuda;
        private Button btnCartelera;
        private Button btnInicio;
        private Panel PanelDatos;
        private Label lblEstado;
        private Label lblPerfil;
        private PictureBox PctPerfil;
        private Label label1;
    }
}