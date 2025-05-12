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
    public partial class PedidosEmpresa : Form
    {
        public PedidosEmpresa()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form logIn = new Form1();
            logIn.Show();
            Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form inicio = new FormEmpresa();
            inicio.Show();
            this.Close();
        }
    }
}
