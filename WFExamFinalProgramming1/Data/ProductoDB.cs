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

        public void InsertProducto(Producto producto)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO productos (sku, nombre, descripcion, precio_compra, precio_venta, precio_mayoreo, stock, fecha_alta, fecha_actualizacion, activo) VALUES (@sku, @nombre, @descripcion, @precio_compra, @precio_venta, @precio_mayoreo, @stock, @fecha_alta, @fecha_actualizacion, @activo)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@sku", producto.Sku);
                command.Parameters.AddWithValue("@nombre", producto.Nombre);
                command.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("@precio_compra", producto.PrecioCompra);
                command.Parameters.AddWithValue("@precio_venta", producto.PrecioVenta);
                command.Parameters.AddWithValue("@precio_mayoreo", producto.PrecioMayoreo);
                command.Parameters.AddWithValue("@stock", producto.Stock);
                command.Parameters.AddWithValue("@fecha_alta", producto.FechaAlta);
                command.Parameters.AddWithValue("@fecha_actualizacion", producto.FechaActualizacion);
                command.Parameters.AddWithValue("@activo", producto.Activo);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateProducto(Producto producto)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE productos SET sku = @sku, nombre = @nombre, descripcion = @descripcion, precio_compra = @precio_compra, precio_venta = @precio_venta, precio_mayoreo = @precio_mayoreo, stock = @stock, fecha_actualizacion = @fecha_actualizacion, activo = @activo WHERE producto_id = @producto_id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@sku", producto.Sku);
                command.Parameters.AddWithValue("@nombre", producto.Nombre);
                command.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("@precio_compra", producto.PrecioCompra);
                command.Parameters.AddWithValue("@precio_venta", producto.PrecioVenta);
                command.Parameters.AddWithValue("@precio_mayoreo", producto.PrecioMayoreo);
                command.Parameters.AddWithValue("@stock", producto.Stock);
                command.Parameters.AddWithValue("@fecha_actualizacion", producto.FechaActualizacion);
                command.Parameters.AddWithValue("@activo", producto.Activo);
                command.Parameters.AddWithValue("@producto_id", producto.Id);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteProducto(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM productos WHERE producto_id = @producto_id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@producto_id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
