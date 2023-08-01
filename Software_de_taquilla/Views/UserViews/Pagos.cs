using Software_de_taquilla.Models.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_de_taquilla.Models.Dto;
using Software_de_taquilla.Helpers;

namespace Software_de_taquilla.Views.UserViews
{
    public partial class Pagos : Form
    {
        public double monto;
        public List<int> asientos;
        public List<Object> objetos;
        public Pagos(List<Object> objetos, List<int> asi)
        {
            this.objetos = objetos;
            this.asientos = asi;
            this.monto = (double)objetos[4];
            InitializeComponent();
            txt_monto.Text = this.monto.ToString();

        }

        private void btn_cobro_Click(object sender, EventArgs e)
        {
            VentaDao vd = new VentaDao();
            BoletoDao bd = new BoletoDao();
            vd.insertVenta((double)this.objetos[4], (int)this.objetos[1]);
            int lastId = vd.getlastID();
            int contador = 0;
            for (int i = 5; i < 8; i++)
            {
                int cant_boletos = (int)this.objetos[i];
                for (int j = 0; j < cant_boletos; j++)
                {
                    Movie mov = (Movie?)this.objetos[2];
                    int id_cine = (int)this.objetos[1];
                    string clas = "Ninguna";
                    if (i == 5) clas = "Adulto";
                    if (i == 6) clas = "Niños";
                    if (i == 7) clas = "Tercera Edad";
                    bd.insertBoleto(lastId, mov.id, id_cine, this.asientos[contador], this.monto, clas);
                    contador++;
                }
            }
            EmailSender.sendEmail(txt_correo.Text);
            MessageBox.Show("Pago realizado, factura enviada a su correo");
        }
    }
}
