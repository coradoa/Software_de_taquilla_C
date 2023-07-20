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
            data_grid = new DataGridView();
            btn_save = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            role_list = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)data_grid).BeginInit();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(39, 42);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(178, 31);
            txt_name.TabIndex = 0;
            // 
            // txt_contrasenia
            // 
            txt_contrasenia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_contrasenia.Location = new Point(39, 105);
            txt_contrasenia.Multiline = true;
            txt_contrasenia.Name = "txt_contrasenia";
            txt_contrasenia.PasswordChar = '*';
            txt_contrasenia.Size = new Size(178, 31);
            txt_contrasenia.TabIndex = 1;
            // 
            // data_grid
            // 
            data_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid.Location = new Point(277, 42);
            data_grid.Name = "data_grid";
            data_grid.RowTemplate.Height = 25;
            data_grid.Size = new Size(536, 226);
            data_grid.TabIndex = 4;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.SeaGreen;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(39, 245);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(178, 23);
            btn_save.TabIndex = 5;
            btn_save.Text = "Guardar";
            btn_save.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 19);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 6;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 87);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 149);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 8;
            label3.Text = "Rol";
            // 
            // role_list
            // 
            role_list.FlatStyle = FlatStyle.Flat;
            role_list.FormattingEnabled = true;
            role_list.Location = new Point(39, 171);
            role_list.Name = "role_list";
            role_list.Size = new Size(178, 23);
            role_list.TabIndex = 9;
            // 
            // UserManagment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 328);
            Controls.Add(role_list);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_save);
            Controls.Add(data_grid);
            Controls.Add(txt_contrasenia);
            Controls.Add(txt_name);
            Name = "UserManagment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserManagment";
            ((System.ComponentModel.ISupportInitialize)data_grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txt_name;
        public TextBox txt_contrasenia;
        public DataGridView data_grid;
        public Button btn_save;
        private Label label1;
        private Label label2;
        private Label label3;
        public ComboBox role_list;
    }
}