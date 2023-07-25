namespace Software_de_taquilla.Views.UserViews
{
    partial class Listing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listing));
            btnNotificacion = new Button();
            dtFecha = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            flow_container = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnNotificacion
            // 
            btnNotificacion.FlatAppearance.BorderSize = 0;
            btnNotificacion.FlatStyle = FlatStyle.Flat;
            btnNotificacion.Image = (Image)resources.GetObject("btnNotificacion.Image");
            btnNotificacion.Location = new Point(624, 41);
            btnNotificacion.Name = "btnNotificacion";
            btnNotificacion.Size = new Size(38, 39);
            btnNotificacion.TabIndex = 25;
            btnNotificacion.UseVisualStyleBackColor = true;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(397, 57);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(200, 23);
            dtFecha.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(12, 64, 76);
            label2.Location = new Point(139, 74);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 17;
            label2.Text = "Cartelera";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(188, 188, 188);
            label1.Location = new Point(139, 48);
            label1.Name = "label1";
            label1.Size = new Size(79, 16);
            label1.TabIndex = 16;
            label1.Text = "Bienvenido";
            // 
            // flow_container
            // 
            flow_container.Location = new Point(32, 125);
            flow_container.Name = "flow_container";
            flow_container.Size = new Size(743, 299);
            flow_container.TabIndex = 26;
            // 
            // Listing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flow_container);
            Controls.Add(btnNotificacion);
            Controls.Add(dtFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Listing";
            Text = "Listing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNotificacion;
        private DateTimePicker dtFecha;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flow_container;
    }
}