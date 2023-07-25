namespace Software_de_taquilla.Views.UserViews.components
{
    partial class MovieCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            picture = new PictureBox();
            label1 = new Label();
            time_line = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.Location = new Point(14, 48);
            picture.Name = "picture";
            picture.Size = new Size(201, 163);
            picture.TabIndex = 0;
            picture.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 1;
            label1.Text = "Mujer Maravilla";
            // 
            // time_line
            // 
            time_line.Location = new Point(16, 217);
            time_line.Name = "time_line";
            time_line.Size = new Size(199, 8);
            time_line.Step = 60;
            time_line.Style = ProgressBarStyle.Continuous;
            time_line.TabIndex = 2;
            time_line.Value = 60;
            // 
            // MovieCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(time_line);
            Controls.Add(label1);
            Controls.Add(picture);
            Name = "MovieCard";
            Size = new Size(226, 245);
            Load += MovieCard_Load;
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picture;
        private Label label1;
        private ProgressBar time_line;
    }
}
