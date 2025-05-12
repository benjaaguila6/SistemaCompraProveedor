using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_compra_a_proveedores
{
    public abstract class Usuario
    {
		private string _user;

		public string User
		{
			get { return _user; }
			set { _user = value; }
		}

		private int _password;

		public int Password
		{
			set { _password = value; }
		}

	}
}
