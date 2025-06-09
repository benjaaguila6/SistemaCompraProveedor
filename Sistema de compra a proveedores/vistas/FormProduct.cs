using Sistema_de_compra_a_proveedores.Modelos;
using Sistema_de_compra_a_proveedores.Vistas;
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

namespace Sistema_de_compra_a_proveedores
{
    public partial class FormProduct : Form
    {
        Archivos archivos = new Archivos();
        Proveedor proveedor = new Proveedor();
        public FormProduct()
        {
            InitializeComponent();
            archivos.cargarProductos("Producto.csv");
            actualizarData();
        }

        private void actualizarData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Producto.ListProduct;
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formPedidos = new FormPedidos();
            formPedidos.Show();
            Close();
        }

        private void infomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formInforme = new FormInforme();
            formInforme.Show();
            Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formInicio = new FormProveedor();
            formInicio.Show();
            Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form logIn = new Form1();
            logIn.Show();
            Close();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            FileStream fsP = new FileStream("Producto.csv", FileMode.Open, FileAccess.Read);
            StreamReader srP = new StreamReader(fsP);

            string lineaP = "";
            string[] vecP = new string[0];

            lineaP = srP.ReadLine();

            Producto.ListProduct.Clear();

            lineaP = srP.ReadLine();

            while (lineaP != null)
            {
                vecP = lineaP.Split(';');
                dataGridView1.Rows.Add(vecP);

                Producto producto = new Producto(int.Parse(vecP[0]), int.Parse(vecP[1]), decimal.Parse(vecP[2]));
                Producto.ListProduct.Add(producto);

                lineaP = srP.ReadLine();
            }

            fsP.Close();
            srP.Close();
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtID.Text);
            int stock = Convert.ToInt16(txtStock.Text);
            decimal precio = decimal.Parse(txtPrecio.Text);

            Producto producto = new Producto(id, stock, precio);
            proveedor.Agregar(producto);
            
            archivos.escribirArchivo("Producto.csv");
            actualizarData();
        }

        private void btnModP_Click(object sender, EventArgs e)
        {
            Producto productoSeleccionado = (Producto)dataGridView1.CurrentRow.DataBoundItem;
            int id = Convert.ToInt16(txtID.Text);
            int stock = Convert.ToInt16(txtStock.Text);
            decimal precio = decimal.Parse(txtPrecio.Text);
            proveedor.Modificar(productoSeleccionado, id, stock, precio);
            
            archivos.escribirArchivo("Producto.csv");
            actualizarData();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            Producto productoSeleccionado = (Producto)dataGridView1.CurrentRow.DataBoundItem;

            proveedor.Eliminar(productoSeleccionado);
            actualizarData();
        }
    }
}
