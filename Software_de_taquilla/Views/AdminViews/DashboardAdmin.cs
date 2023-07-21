using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_de_taquilla.Views.AdminViews
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.TabStop = false; // Deshabilitar el enfoque del control para evitar que se muestre el marco cuando se selecciona.
            pictureBox1.BorderStyle = BorderStyle.None;
        }
    }
}
