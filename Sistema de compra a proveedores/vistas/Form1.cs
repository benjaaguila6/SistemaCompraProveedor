using Sistema_de_compra_a_proveedores.Modelos;
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
            string email = txtUser.Text;
            string password = txtPassword.Text;

            verificarUsuario(email, password);
        }

        private void verificarUsuario(string email, string password)
        {
            Usuario usuario = Usuario.ListUsuarios.FirstOrDefault(u => u.Email == email);
            if (usuario != null)
            {
                if (usuario.Password == password)
                {
                    MessageBox.Show($"Inicio de sesion exitoso. Rol: {usuario.Rol}");

                    if (usuario.Rol == "Proveedorr")
                    {
                        FormProveedor form = new FormProveedor();
                        form.ShowDialog();
                    }
                    else if (usuario.Rol == "Empresa")
                    {
                        FormEmpresa form = new FormEmpresa();
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show($"Contrasena incorrecta");
                    }
                }
            }
            else
            {
                MessageBox.Show("Correo electronico no registrado");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Form formRegister = new FormRegister();
            formRegister.Show();

        }
    }
}