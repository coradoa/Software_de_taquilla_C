namespace Software_de_taquilla.Views.UserViews
{
    partial class Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.txt_notarjeta = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_cvv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fechav = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(56, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pago";
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_correo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_correo.Location = new System.Drawing.Point(66, 90);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(331, 31);
            this.txt_correo.TabIndex = 1;
            this.txt_correo.Text = "ejemplo@gmail.com";
            this.txt_correo.Click += new System.EventHandler(this.txt_correo_Click);
            this.txt_correo.Leave += new System.EventHandler(this.txt_correo_Leave);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_telefono.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_telefono.Location = new System.Drawing.Point(455, 94);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(276, 31);
            this.txt_telefono.TabIndex = 2;
            this.txt_telefono.Text = "Teléfono";
            this.txt_telefono.Click += new System.EventHandler(this.txt_telefono_Click);
            this.txt_telefono.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txt_telefono.Leave += new System.EventHandler(this.txt_telefono_Leave);
            // 
            // txt_monto
            // 
            this.txt_monto.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_monto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_monto.Location = new System.Drawing.Point(66, 156);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(331, 31);
            this.txt_monto.TabIndex = 3;
            this.txt_monto.Text = "Q.245.00 ";
            this.txt_monto.Click += new System.EventHandler(this.txt_monto_Click);
            this.txt_monto.Leave += new System.EventHandler(this.txt_monto_Leave);
            // 
            // txt_notarjeta
            // 
            this.txt_notarjeta.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_notarjeta.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_notarjeta.Location = new System.Drawing.Point(66, 216);
            this.txt_notarjeta.Name = "txt_notarjeta";
            this.txt_notarjeta.Size = new System.Drawing.Size(331, 31);
            this.txt_notarjeta.TabIndex = 4;
            this.txt_notarjeta.Text = "Número de Tarjeta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(455, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txt_cvv
            // 
            this.txt_cvv.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cvv.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_cvv.Location = new System.Drawing.Point(66, 291);
            this.txt_cvv.Name = "txt_cvv";
            this.txt_cvv.Size = new System.Drawing.Size(331, 31);
            this.txt_cvv.TabIndex = 6;
            this.txt_cvv.Text = "CVV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(66, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "CVV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(455, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de vencimiento";
            // 
            // txt_fechav
            // 
            this.txt_fechav.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_fechav.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_fechav.Location = new System.Drawing.Point(455, 290);
            this.txt_fechav.Name = "txt_fechav";
            this.txt_fechav.Size = new System.Drawing.Size(276, 31);
            this.txt_fechav.TabIndex = 9;
            this.txt_fechav.Text = "dd/mm/yyyy";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(455, 163);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(246, 29);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pago con tarjeta de credito";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(467, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(66, 341);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 537);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txt_fechav);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cvv);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_notarjeta);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label1);
            this.Name = "Pagos";
            this.Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_correo;
        private TextBox txt_telefono;
        private TextBox txt_monto;
        private TextBox txt_notarjeta;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_cvv;
        private Label label2;
        private Label label3;
        private TextBox txt_fechav;
        private RadioButton radioButton1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}