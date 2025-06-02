using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_compra_a_proveedores.Modelos
{
    public partial class FormRegister : Form
    {
        Archivos archi = new Archivos();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtUserRegister.Text;
            string password = txtPasswordRegister.Text;
            string nombre = txtNombre.Text;
            Usuario user = new Usuario(nombre, email, password);
            Usuario.ListUsuarios.Add(user);
            archi.escribirArchivo("Usuarios.csv");
        }
    }
}
