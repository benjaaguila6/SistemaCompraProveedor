using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_compra_a_proveedores
{
    public class Empresa : Usuario
    {
		private int _codEmpresa;

		public int CodEmpresa
		{
			get { return _codEmpresa; }
			set { _codEmpresa = value; }
		}

	}
}
