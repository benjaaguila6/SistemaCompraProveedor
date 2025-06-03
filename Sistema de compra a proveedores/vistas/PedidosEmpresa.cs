using Sistema_de_compra_a_proveedores.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PedidosEmpresa_Load(object sender, EventArgs e)
        {

            FileStream fsP = new FileStream("Pedidos.csv", FileMode.Open, FileAccess.Read);
            StreamReader srP = new StreamReader(fsP);

            string lineaP = "";
            string[] vecP = new string[0];

            lineaP = srP.ReadLine();

            Pedido.ListPedido.Clear();

            lineaP = srP.ReadLine();

            while (lineaP != null)
            {
                vecP = lineaP.Split(';');
                dataGridView1.Rows.Add(vecP);

                Pedido pedido = new Pedido(int.Parse(vecP[0]), DateTime.Parse(vecP[1]), DateTime.Parse(vecP[2]), bool.Parse(vecP[3]), bool.Parse(vecP[4]), int.Parse(vecP[5]), int.Parse(vecP[6]));
                Pedido.ListPedido.Add(pedido);

                lineaP = srP.ReadLine();
            }

            fsP.Close();
            srP.Close();


        }
    }
}
