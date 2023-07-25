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
            LoginController usr = new LoginController(this);
        }

        public void printMessage(string msg) { MessageBox.Show(msg); }
    }
}
