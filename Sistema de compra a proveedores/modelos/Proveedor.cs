using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_compra_a_proveedores
{
    public class Proveedor : Usuario
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

	}
}
