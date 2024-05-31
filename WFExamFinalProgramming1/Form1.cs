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
    }
}
