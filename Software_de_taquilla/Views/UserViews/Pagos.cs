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
    public partial class Pagos : Form
    {
        public double monto;
        public List<int> asientos;
        public Pagos(List<Object> objetos, List<int> asi)
        {
            this.asientos = asi;
            this.monto = (double)objetos[4];
            InitializeComponent();
            txt_monto.Text = this.monto.ToString();

        }

        private void btn_cobro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado");
        }
    }
}
