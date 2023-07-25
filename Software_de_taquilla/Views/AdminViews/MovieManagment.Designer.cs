namespace Software_de_taquilla.Views.AdminViews
{
    partial class MovieManagment
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
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.txt_publico = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_duracion = new System.Windows.Forms.NumericUpDown();
            this.list_listing = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_picture = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.room_listing = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_duracion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(849, 419);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(118, 31);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "Actualizar";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(1026, 419);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(118, 31);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Duracion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Publico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(30, 384);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(203, 31);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // data_grid
            // 
            this.data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Location = new System.Drawing.Point(501, 23);
            this.data_grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_grid.Name = "data_grid";
            this.data_grid.RowHeadersWidth = 51;
            this.data_grid.RowTemplate.Height = 25;
            this.data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_grid.Size = new System.Drawing.Size(645, 377);
            this.data_grid.TabIndex = 15;
            // 
            // txt_publico
            // 
            this.txt_publico.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_publico.Location = new System.Drawing.Point(30, 136);
            this.txt_publico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_publico.Name = "txt_publico";
            this.txt_publico.Size = new System.Drawing.Size(203, 32);
            this.txt_publico.TabIndex = 14;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(30, 65);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(203, 32);
            this.txt_name.TabIndex = 13;
            // 
            // txt_duracion
            // 
            this.txt_duracion.Location = new System.Drawing.Point(296, 79);
            this.txt_duracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_duracion.Name = "txt_duracion";
            this.txt_duracion.Size = new System.Drawing.Size(137, 27);
            this.txt_duracion.TabIndex = 25;
            // 
            // list_listing
            // 
            this.list_listing.FormattingEnabled = true;
            this.list_listing.Location = new System.Drawing.Point(295, 159);
            this.list_listing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.list_listing.Name = "list_listing";
            this.list_listing.Size = new System.Drawing.Size(138, 28);
            this.list_listing.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cartelera";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_picture);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.room_listing);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.list_listing);
            this.panel1.Controls.Add(this.txt_publico);
            this.panel1.Controls.Add(this.txt_duracion);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 433);
            this.panel1.TabIndex = 28;
            // 
            // panel_picture
            // 
            this.panel_picture.AllowDrop = true;
            this.panel_picture.BackColor = System.Drawing.Color.Silver;
            this.panel_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_picture.Location = new System.Drawing.Point(31, 207);
            this.panel_picture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_picture.Name = "panel_picture";
            this.panel_picture.Size = new System.Drawing.Size(202, 133);
            this.panel_picture.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Imagen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Sala";
            // 
            // room_listing
            // 
            this.room_listing.FormattingEnabled = true;
            this.room_listing.Location = new System.Drawing.Point(295, 255);
            this.room_listing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.room_listing.Name = "room_listing";
            this.room_listing.Size = new System.Drawing.Size(138, 28);
            this.room_listing.TabIndex = 29;
            // 
            // MovieManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.data_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MovieManagment";
            this.Text = "MovieManagment";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_duracion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Button btn_update;
        public Button btn_delete;
        private Label label3;
        private Label label2;
        private Label label1;
        public Button btn_save;
        public DataGridView data_grid;
        public TextBox txt_publico;
        public TextBox txt_name;
        private Label label4;
        private Panel panel1;
        private Label label5;
        public NumericUpDown txt_duracion;
        public ComboBox list_listing;
        public ComboBox room_listing;
        private Label label6;
        public Panel panel_picture;
    }
}