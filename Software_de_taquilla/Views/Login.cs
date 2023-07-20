using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_de_taquilla.Controllers;

namespace Software_de_taquilla.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            UserController usr = new UserController(this);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void printMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_Click(object sender, EventArgs e)
        {
            txt_pass.Text = "";
            txt_pass.ForeColor = Color.Black;
            txt_pass.PasswordChar = '*';
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            txt_pass.Text = "Contraseña";
            txt_pass.ForeColor = SystemColors.WindowFrame;
            txt_pass.PasswordChar = '\0';
        }
    }
}
