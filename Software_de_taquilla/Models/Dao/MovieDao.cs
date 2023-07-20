using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Models.Dao
{
    public class MovieDao : DBContext
    {
        public List<Movie> getMovies()
        {
            this.connection.Open();
            List<Movie> movies = new List<Movie>();
            string sql = "select * from pelicula";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(1);
                string name = reader.GetString(2);
                string image = reader.GetString(3);
                string public_ = reader.GetString(4);
                string duration = reader.GetString(5);
                int id_listing = reader.GetInt32(6);
                int id_room = reader.GetInt32(7);
                Movie movie = new Movie(id, name, image, duration, id_listing, id_room, public_);
                movies.Add(movie);
            }
            this.connection.Close();
            return movies;
        }

        public void insertMovie(int id, string name, string image, string duration, int id_listing, int id_room, string p)
        {
            this.connection.Open();
            string query = "INSERT INTO Pelicula (id, nombre, imagen, publico, duracion, id_cartelera, id_sala)VALUES";
            query += "('" + id + "', '" + name + "', '" + image + "', '" + duration + "', '" + id_listing + "', '" + id_room + "', '" + p + "');";
            MySqlCommand cursor = new MySqlCommand(query, this.connection);
            cursor.ExecuteNonQuery();
            this.connection.Close();
        }
    }
}
