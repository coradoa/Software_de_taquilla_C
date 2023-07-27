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
        public ListingView view;
        public ListingController(ListingView view)
        {
            this.view = view;
            this.view.Load += new EventHandler(this.buildComponent);
            this.view.combo_city.SelectedIndexChanged += new EventHandler(this.filtrar);
        }

        public void filtrar(object sender, EventArgs e)
        {
            this.view.flow_container.Controls.Clear();
            this.fillMovies(this.view.combo_city.SelectedIndex + 1);
        }

        public void fillMovies(int n)
        {

            MovieDao mydao = new MovieDao();
            List<Movie> movies = new List<Movie>();
            if (n == -1) movies = mydao.getMovies();
            else movies = mydao.getMovies(n);
            var date = DateTime.Now;
            int h = date.Hour;
            int m = date.Minute;
            foreach (Movie movie in movies)
            {
                this.view.flow_container.Controls.Add(new MovieCard(movie, h, m));
            }
        }


        public void buildComponent(object sender, EventArgs e)
        {
            this.fillCity();
            this.fillMovies(-1);
        }

        public void fillCity()
        {
            CityDao mydao = new CityDao();
            List<City> cts = mydao.getCitys();
            foreach (City c in cts)
            {
                this.view.combo_city.Items.Add(c.name);
            }
        }
    }
}
