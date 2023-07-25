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

namespace Software_de_taquilla.Views.UserViews
{
    public partial class Listing : Form
    {
        public Listing()
        {
            InitializeComponent();
            ListingController controller = new ListingController(this);
        }
    }
}
