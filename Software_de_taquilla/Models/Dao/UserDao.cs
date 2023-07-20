using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
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
            string query = "select * from user where nombre='" + username + "' and contrasenia='" + password + "'";
            MySqlCommand cursor = new MySqlCommand(query, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            exist = reader.Read();
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
    }
}
