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
    public partial class FormEmpresa : Form
    {
        public FormEmpresa()
        {
            InitializeComponent();
        }


        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form logIn = new Form1();
            logIn.Show();
            this.Close();
        }

        private void misPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pedidos = new PedidosEmpresa();
            pedidos.Show();
            this.Close();
        }
    }
}
