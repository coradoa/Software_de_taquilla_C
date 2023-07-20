using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Models.Dao
{
    public class UserDao : DBContext
    {

        public bool isConnected()
        {
            this.connection.Open();
            return this.connection != null;
        }
        public bool userExist(string username, string password)
        {
            bool exist = false;
            this.connection.Open();
            string query = "select * from usuario where nombre='" + username + "' and contrasenia='" + password + "'";
            MySqlCommand cursor = new MySqlCommand(query, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            if (reader.HasRows) exist = true;
            this.connection.Close();
            return exist;
        }

        public void insertUser(string username, string pass, int rol)
        {
            this.connection.Open();
            string sql = "insert into usuario(nombre, contrasenia, rol)values('" + username + "', '" + pass + "', '" + rol + "')";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            cursor.ExecuteNonQuery();
            this.connection.Close();
        }

        public List<User> getUsers()
        {
            this.connection.Open();
            List<User> users = new List<User>();
            string sql = "select * from pelicula";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(1);
                string name = reader.GetString(2);
                string pass = reader.GetString(3);
                int rol = reader.GetInt32(4);
                User usr = new User(id, name, pass, rol);
                users.Add(usr);
            }
            this.connection.Close();
            return users;
        }
    }
}
