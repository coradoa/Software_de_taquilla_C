using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_de_taquilla.Views.UserViews
{
    public partial class SeleccionBoletos : Form
    {
        public SeleccionBoletos()
        {
            InitializeComponent();
        }

        private void btna_1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_n1.Text) + 1;
            txt_n1.Text = n.ToString();
        }

        private void btna_2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_n1.Text) - 1;
            if (n > 0) txt_n1.Text = n.ToString();
        }

        private void btnn_1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_n2.Text) + 1;
            txt_n2.Text = n.ToString();

        }

        private void btnn_2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_n2.Text) - 1;
            if (n > 0) txt_n2.Text = n.ToString();
        }

        private void btn_e1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_n3.Text) + 1;
            txt_n3.Text = n.ToString();
        }

        private void btn_e2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txt_n3.Text) - 1;
            if (n > 0) txt_n3.Text = n.ToString();
        }
    }
}
