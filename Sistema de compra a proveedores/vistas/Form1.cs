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

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formProduct = new FormProduct();
            formProduct.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formPedido = new FormPedidos();
            formPedido.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formInforme = new FormInforme();
            formInforme.Show();
        }
    }
}
