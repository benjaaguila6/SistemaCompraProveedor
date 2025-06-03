using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_compra_a_proveedores
{
    public class Usuario
    {
        public static List<Usuario> ListUsuarios = new List<Usuario>();


        private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		private string _password;

		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		private string _rol;

		public string Rol
		{
			get { return _rol; }
			set { _rol = value; }
		}

		public Usuario()
		{

		}

        public Usuario(string n, string e, string p)
        {
            Name = n;
			Email = e;
			Password = p;
            
        }
    }
}
