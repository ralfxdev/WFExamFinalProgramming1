using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFExamFinalProgramming1.Data.Models;

namespace WFExamFinalProgramming1.Data
{
    internal class ProductoDB
    {
        private string connectionString = "Server=localhost;Database=final_exam;Uid=root;Pwd=282001";

        public List<Producto> GetProductos()
        {
            List<Producto> productos = new List<Producto>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM productos";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto = new Producto();
                    producto.Sku = reader["sku"].ToString();
                    producto.Nombre = reader["nombre"].ToString();
                    producto.Descripcion = reader["descripcion"].ToString();
                    producto.PrecioCompra = Convert.ToDecimal(reader["precio_compra"]);
                    producto.PrecioVenta = Convert.ToDecimal(reader["precio_venta"]);
                    producto.PrecioMayoreo = Convert.ToDecimal(reader["precio_mayoreo"]);
                    producto.Stock = Convert.ToInt32(reader["stock"]);
                    producto.FechaAlta = Convert.ToDateTime(reader["fecha_alta"]);
                    producto.FechaActualizacion = Convert.ToDateTime(reader["fecha_actualizacion"]);
                    producto.Activo = Convert.ToBoolean(reader["activo"]);
                    productos.Add(producto);
                }
            }

            return productos;
        }

        public Producto GetProductoById(int id)
        {
            Producto producto = new Producto();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM productos WHERE producto_id = @producto_id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@producto_id", id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    producto.Sku = reader["sku"].ToString();
                    producto.Nombre = reader["nombre"].ToString();
                    producto.Descripcion = reader["descripcion"].ToString();
                    producto.PrecioCompra = Convert.ToDecimal(reader["precio_compra"]);
                    producto.PrecioVenta = Convert.ToDecimal(reader["precio_venta"]);
                    producto.PrecioMayoreo = Convert.ToDecimal(reader["precio_mayoreo"]);
                    producto.Stock = Convert.ToInt32(reader["stock"]);
                    producto.FechaAlta = Convert.ToDateTime(reader["fecha_alta"]);
                    producto.FechaActualizacion = Convert.ToDateTime(reader["fecha_actualizacion"]);
                    producto.Activo = Convert.ToBoolean(reader["activo"]);
                }
            }
            return producto;
        }
    }
}
