using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Models.Dao
{
    public class VentaDao: DBContext
    {

        public bool isConnected()
        {
            this.connection.Open();
            return this.connection != null;
        }


        public void insertVenta(int id_venta, double total, int id_cine)
        {
            this.connection.Open();
            string sql = "insert into venta(id_venta, total, id_cine)values('"+id_venta+"', '"+total+"', '"+id_cine+"')";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            cursor.ExecuteNonQuery();
            this.connection.Close();
        }

        public List<Venta> getVenta()
        {
            this.connection.Open();
            List<Venta> ventas = new List<Venta>();
            string sql = "select * from venta";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                double total = reader.GetDouble(1);
                int id_cine = reader.GetInt32(2);
                Venta venta = new Venta(id, total, id_cine);
                ventas.Add(venta);
            }
            this.connection.Close();
            return ventas;
        }

    }
}
