using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Views.UserViews;
using Software_de_taquilla.Models.Dao;
using Software_de_taquilla.Models.Dto;
using Software_de_taquilla.Views.UserViews.components;

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
            MovieDao mydao = new MovieDao();
            List<Movie> movies = mydao.getMovies();
            var date = DateTime.Now;
            int h = date.Hour;
            int m = date.Minute;
            foreach (Movie movie in movies)
            {
                this.view.flow_container.Controls.Add(new MovieCard(movie, h, m));
            }
        }
    }
}
