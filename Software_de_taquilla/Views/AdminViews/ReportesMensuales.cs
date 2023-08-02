using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_de_taquilla.Models.Dao;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Views.AdminViews
{
    public partial class ReportesMensuales : Form
    {
        public ReportesMensuales()
        {
            InitializeComponent();
        }


        public void fillData()
        {

        }


        private void btn_IngresoS_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminViews.ReportesSemanales rp = new AdminViews.ReportesSemanales();
            rp.ShowDialog();
            this.Visible = true;
        }
    }
}
