using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_compra_a_proveedores.Vistas
{
    public partial class FormProveedor : Form
    {
        public FormProveedor()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formProducto = new FormProduct();
            formProducto.Show();
            Close();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formPedidos = new FormPedidos();
            formPedidos.Show();
            Close();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formInforme = new FormInforme();
            formInforme.Show();
            Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form logIn = new Form1();
            logIn.Show();
            Close();
        }
    }
}
