using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFExamFinalProgramming1.Data.Models
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioMayoreo { get; set; }
        public int Stock { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool Activo { get; set; }

        public Producto(int id, string sku, string nombre, string descripcion, decimal precioCompra, decimal precioVenta, decimal precioMayoreo, int stock, DateTime fechaAlta, DateTime fechaActualizacion, bool activo)
        {
            Id = id;
            Sku = sku;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            PrecioMayoreo = precioMayoreo;
            Stock = stock;
            FechaAlta = fechaAlta;
            FechaActualizacion = fechaActualizacion;
            Activo = activo;
        }

        public Producto() { }
    }
}
