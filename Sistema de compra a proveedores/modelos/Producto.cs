using Sistema_de_compra_a_proveedores.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_compra_a_proveedores
{
    public class Producto : ABM
    {
        public static List<Producto> ListProduct = new List<Producto>();

        private int _codProducto;

        public int CodProducto
        {
            get { return _codProducto; }
            set { _codProducto = value; }
        }

        private int _stock;

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        private decimal _precio;

        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public Producto(int CodProducto, int Stock, decimal Precio)
        {
          _codProducto =CodProducto;
          _precio =Precio;
          _stock =Stock;
        }
        public void Agregar()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }
    }
}
