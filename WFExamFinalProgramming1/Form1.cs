using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFExamFinalProgramming1.Data;
using WFExamFinalProgramming1.Data.Models;

namespace WFExamFinalProgramming1
{
    public partial class CRUD : Form
    {
        private ProductoDB productoDB;

        public CRUD()
        {
            InitializeComponent();
            productoDB = new ProductoDB();
            totalProductosTxt.Text = productoDB.GetTotalProductos().ToString();
        }

        private void leerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                productosGridView.DataSource = productoDB.GetProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(idTxt.Text))
                {
                    MessageBox.Show("Por favor ingrese el Id del producto", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(idTxt.Text);
                Producto producto = productoDB.GetProductoById(id);
                if (producto.Sku != null)
                {
                    skuTxt.Text = producto.Sku;
                    nombreTxt.Text = producto.Nombre;
                    descripcionTxt.Text = producto.Descripcion;
                    precioCompraTxt.Text = producto.PrecioCompra.ToString();
                    precioVentaTxt.Text = producto.PrecioVenta.ToString();
                    precioMayoreoTxt.Text = producto.PrecioMayoreo.ToString();
                    stockTxt.Text = producto.Stock.ToString();
                    fechaCreacionTxt.Text = producto.FechaAlta.ToString();
                    fechaActualizacionTxt.Text = producto.FechaActualizacion.ToString();
                    disponibleCheck.Checked = producto.Activo;

                    leerBtn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("No se encontró el producto con el ID proporcionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al buscar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productosGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(skuTxt.Text))
                {
                    MessageBox.Show("Por favor ingrese el SKU del producto", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(nombreTxt.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre del producto", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(precioCompraTxt.Text))
                {
                    MessageBox.Show("Por favor ingrese el precio de compra del producto", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(precioVentaTxt.Text))
                {
                    MessageBox.Show("Por favor ingrese el precio de venta del producto", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Producto producto = new Producto();
                producto.Sku = skuTxt.Text;
                producto.Nombre = nombreTxt.Text;
                producto.Descripcion = descripcionTxt.Text;
                producto.PrecioCompra = Convert.ToDecimal(precioCompraTxt.Text);
                producto.PrecioVenta = Convert.ToDecimal(precioVentaTxt.Text);
                producto.PrecioMayoreo = Convert.ToDecimal(precioMayoreoTxt.Text);
                producto.Stock = Convert.ToInt32(stockTxt.Text);
                producto.Activo = disponibleCheck.Checked;

                productoDB.InsertProducto(producto);
                MessageBox.Show("Producto creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                leerBtn_Click(sender, e);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al crear el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(idTxt.Text))
                {
                    MessageBox.Show("Por favor ingrese el Id del producto", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(skuTxt.Text))
                {
                    MessageBox.Show("Por favor ingrese el SKU del producto", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(nombreTxt.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre del producto", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(precioCompraTxt.Text))
                {
                    MessageBox.Show("Por favor ingrese el precio de compra del producto", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(precioVentaTxt.Text))
                {
                    MessageBox.Show("Por favor ingrese el precio de venta del producto", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Producto producto = new Producto();
                producto.Id = Convert.ToInt32(idTxt.Text);
                producto.Sku = skuTxt.Text;
                producto.Nombre = nombreTxt.Text;
                producto.Descripcion = descripcionTxt.Text;
                producto.PrecioCompra = Convert.ToDecimal(precioCompraTxt.Text);
                producto.PrecioVenta = Convert.ToDecimal(precioVentaTxt.Text);
                producto.PrecioMayoreo = Convert.ToDecimal(precioMayoreoTxt.Text);
                producto.Stock = Convert.ToInt32(stockTxt.Text);
                producto.Activo = disponibleCheck.Checked;

                productoDB.UpdateProducto(producto);
                MessageBox.Show("Producto actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                leerBtn_Click(sender, e);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(idTxt.Text))
                {
                    MessageBox.Show("Por favor ingrese el Id del producto", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(idTxt.Text);
                productoDB.DeleteProducto(id);
                MessageBox.Show("Producto eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                leerBtn_Click(sender, e);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            idTxt.Text = "";
            skuTxt.Text = "";
            nombreTxt.Text = "";
            descripcionTxt.Text = "";
            precioCompraTxt.Text = "0.00";
            precioVentaTxt.Text = "0.00";
            precioMayoreoTxt.Text = "0.00";
            stockTxt.Text = "0";
            fechaCreacionTxt.Text = "N/A";
            fechaActualizacionTxt.Text = "N/A";
            disponibleCheck.Checked = false;
        }

        private void reiniciarBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void activosBtn_Click(object sender, EventArgs e)
        {
            try
            {
                productosGridView.DataSource = productoDB.GetProductosByActivo(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al cargar los productos activos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inactivosBtn_Click(object sender, EventArgs e)
        {
            try
            {
                productosGridView.DataSource = productoDB.GetProductosByActivo(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al cargar los productos inactivos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscarFiltroBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(buscarTxt.Text))
                {
                    MessageBox.Show("Por favor ingrese el filtro de búsqueda", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                productosGridView.DataSource = productoDB.GetProductosByNombre(buscarTxt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al buscar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
