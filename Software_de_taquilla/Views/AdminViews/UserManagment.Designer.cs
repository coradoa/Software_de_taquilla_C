namespace Software_de_taquilla.Views.AdminViews
{
    partial class UserManagment
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
            txt_name = new TextBox();
            txt_contrasenia = new TextBox();
            txt_rol = new TextBox();
            data_grid = new DataGridView();
            btn_save = new Button();
            ((System.ComponentModel.ISupportInitialize)data_grid).BeginInit();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Location = new Point(39, 42);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(178, 31);
            txt_name.TabIndex = 0;
            // 
            // txt_contrasenia
            // 
            txt_contrasenia.Location = new Point(39, 105);
            txt_contrasenia.Multiline = true;
            txt_contrasenia.Name = "txt_contrasenia";
            txt_contrasenia.Size = new Size(178, 31);
            txt_contrasenia.TabIndex = 1;
            // 
            // txt_rol
            // 
            txt_rol.Location = new Point(39, 168);
            txt_rol.Multiline = true;
            txt_rol.Name = "txt_rol";
            txt_rol.Size = new Size(178, 31);
            txt_rol.TabIndex = 2;
            // 
            // data_grid
            // 
            data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid.Location = new Point(277, 42);
            data_grid.Name = "data_grid";
            data_grid.RowTemplate.Height = 25;
            data_grid.Size = new Size(536, 226);
            data_grid.TabIndex = 4;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(39, 245);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(178, 23);
            btn_save.TabIndex = 5;
            btn_save.Text = "Guardar";
            btn_save.UseVisualStyleBackColor = true;
            // 
            // UserManagment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 328);
            Controls.Add(btn_save);
            Controls.Add(data_grid);
            Controls.Add(txt_rol);
            Controls.Add(txt_contrasenia);
            Controls.Add(txt_name);
            Name = "UserManagment";
            Text = "UserManagment";
            ((System.ComponentModel.ISupportInitialize)data_grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txt_name;
        public TextBox txt_contrasenia;
        public TextBox txt_rol;
        public DataGridView data_grid;
        public Button btn_save;
    }
}