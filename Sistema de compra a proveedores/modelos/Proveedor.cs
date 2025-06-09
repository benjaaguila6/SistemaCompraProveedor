using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_compra_a_proveedores
{
    public class Proveedor : Usuario, ABM
    {
		private int _codProveedor;

		public int CodigoProveedor
		{
			get { return _codProveedor; }
			set { _codProveedor = value; }
		}

		private string _rubro;

		public string Rubro
		{
			get { return _rubro; }
			set { _rubro = value; }
		}

        public void Modificar(Producto p, int cod, int stock, decimal precio)
        {
            p.CodProducto = cod;
            p.Stock = stock;
            p.Precio = precio;
        }

        public void Agregar(Producto p)
        {
            Producto.ListProduct.Add(p);
        }

        public void Eliminar(Producto p)
        {
            Producto.ListProduct.Remove(p);
        }
    }
}
