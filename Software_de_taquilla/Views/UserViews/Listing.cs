using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_de_taquilla.Views.UserViews.components;

namespace Software_de_taquilla.Views.UserViews
{
    public partial class Listing : Form
    {
        public Listing()
        {
            InitializeComponent();
            this.fillContainer();
        }

        public void fillContainer()
        {
            for (int i = 0; i < 5; i++)
            {
                flow_container.Controls.Add(new MovieCard());
            }
        }
    }
}
