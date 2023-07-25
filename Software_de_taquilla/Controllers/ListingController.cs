using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Views.UserViews;

namespace Software_de_taquilla.Controllers
{
    public class ListingController
    {
        public Listing view;
        public ListingController(Listing view)
        {
            this.view = view;
            this.view.Load += new EventHandler(this.buildComponent);
        }

        public void buildComponent(object sender, EventArgs e)
        {

        }
    }
}
