namespace Software_de_taquilla.Views
{
    partial class Login
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
            txt_user = new TextBox();
            txt_pass = new TextBox();
            btn_login = new Button();
            panel1 = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_user
            // 
            txt_user.BackColor = Color.White;
            txt_user.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.ForeColor = SystemColors.WindowFrame;
            txt_user.Location = new Point(558, 85);
            txt_user.Multiline = true;
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(230, 29);
            txt_user.TabIndex = 0;
            txt_user.Text = "Usuario";
            txt_user.Click += txt_user_Click;
            txt_user.Leave += txt_user_Leave;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.ForeColor = SystemColors.WindowFrame;
            txt_pass.Location = new Point(556, 154);
            txt_pass.Multiline = true;
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(229, 30);
            txt_pass.TabIndex = 1;
            txt_pass.Text = "Contraseña";
            txt_pass.Click += txt_pass_Click_1;
            txt_pass.Leave += txt_pass_Leave_1;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DarkSlateGray;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(556, 226);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(231, 25);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 171, 218);
            panel1.Location = new Point(-1, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 376);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.Location = new Point(626, 21);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(918, 376);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btn_login;
        private Panel panel1;
        private Label label1;
        public TextBox txt_user;
        public TextBox txt_pass;
    }
}