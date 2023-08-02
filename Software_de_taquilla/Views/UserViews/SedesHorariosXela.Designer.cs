namespace Software_de_taquilla.Views.UserViews
{
    partial class SedesHorariosXela
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
            txt = new TextBox();
            SuspendLayout();
            // 
            // txt
            // 
            txt.Location = new Point(83, 74);
            txt.Multiline = true;
            txt.Name = "txt";
            txt.ScrollBars = ScrollBars.Vertical;
            txt.Size = new Size(487, 226);
            txt.TabIndex = 0;
            // 
            // SedesHorariosXela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(676, 427);
            Controls.Add(txt);
            Name = "SedesHorariosXela";
            Text = "SedesHorariosXela";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txt;
    }
}