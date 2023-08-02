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
            this.fillData();
        }


        public void fillData()
        {
            VentaDao vdao = new VentaDao();
            List<Venta> ventas = vdao.getVenta();
            this.data_grid.ColumnCount = 4;
            this.data_grid.Columns[0].Name = "ID";
            this.data_grid.Columns[1].Name = "Cine";
            this.data_grid.Columns[2].Name = "Fecha";
            this.data_grid.Columns[3].Name = "Total";
            foreach (Venta venta in ventas)
            {
                this.data_grid.Rows.Add(venta.id, venta.id_cine, venta.fecha, venta.total);
            }
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
