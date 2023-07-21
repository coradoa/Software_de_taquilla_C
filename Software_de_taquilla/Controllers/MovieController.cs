using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.Mozilla;
using Software_de_taquilla.Views.AdminViews;
using Software_de_taquilla.Models.Dao;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Controllers
{
    public class MovieController
    {
        MovieManagment view;
        public MovieController(MovieManagment view)
        {
            this.view = view;
            this.view.Load += new EventHandler(this.buildComponent);
        }


        public void buildComponent(Object sender, EventArgs e)
        {
            this.fillDataGrid();
        }

        public void fillDataGrid()
        {
            view.data_grid.Rows.Clear();
            MovieDao dao = new MovieDao();
            List<Movie> movies = dao.getMovies();
            view.data_grid.ColumnCount = 7;
            view.data_grid.Columns[0].Name = "ID";
            view.data_grid.Columns[1].Name = "Nombre";
            view.data_grid.Columns[2].Name = "Publico";
            view.data_grid.Columns[3].Name = "Duracion";
            view.data_grid.Columns[4].Name = "Cartelera";
            view.data_grid.Columns[5].Name = "Sala";
            foreach (Movie movie in movies)
            {
                view.data_grid.Rows.Add(movie.id, movie.name, movie.public_, movie.id_listing, movie.id_room);
            }
        }
    }
}



