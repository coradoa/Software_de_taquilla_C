namespace Software_de_taquilla.Views.UserViews
{
    partial class MovieSelection
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
            picture = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel_horarios = new FlowLayoutPanel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.Location = new Point(12, 48);
            picture.Name = "picture";
            picture.Size = new Size(314, 193);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 0;
            picture.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.Size = new Size(48, 16);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 253);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 253);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 253);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // panel_horarios
            // 
            panel_horarios.AutoScroll = true;
            panel_horarios.Location = new Point(364, 48);
            panel_horarios.Name = "panel_horarios";
            panel_horarios.Size = new Size(133, 193);
            panel_horarios.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(361, 19);
            label5.Name = "label5";
            label5.Size = new Size(144, 17);
            label5.TabIndex = 6;
            label5.Text = "CONSULTA HORARIOS";
            // 
            // MovieSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 294);
            Controls.Add(label5);
            Controls.Add(panel_horarios);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picture);
            Name = "MovieSelection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovieSelection";
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public PictureBox picture;
        private FlowLayoutPanel panel_horarios;
        private Label label5;
    }
}