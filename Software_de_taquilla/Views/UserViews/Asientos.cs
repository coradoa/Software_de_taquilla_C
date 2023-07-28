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
    public partial class Asientos : Form
    {
        public Asientos()
        {
            InitializeComponent();
            this.createEffects();
        }


        public void clickEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == System.Drawing.Color.WhiteSmoke)
            {
                btn.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                btn.BackColor = System.Drawing.Color.WhiteSmoke;
            }
        }

        public void createEffects()
        {
            foreach (Control button in panel2.Controls)
            {
                if (button is Button)
                {
                    button.Click += new EventHandler(this.clickEvent);
                }
            }
        }
    }
}
