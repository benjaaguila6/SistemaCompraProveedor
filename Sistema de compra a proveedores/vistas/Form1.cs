using Sistema_de_compra_a_proveedores.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_compra_a_proveedores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "proveedor" &&  txtPassword.Text == "123")
            {
                Form formProveedor = new FormProveedor();
                formProveedor.Show();
            }
            else if(txtUser.Text == "empresa" && txtPassword.Text == "123")
            {
                Form formEmpresa = new FormEmpresa();
                formEmpresa.Show();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos.");
            }

            txtPassword.Clear();
            txtUser.Clear();
        }
    }
}
