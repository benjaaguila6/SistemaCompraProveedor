﻿using Sistema_de_compra_a_proveedores.Vistas;
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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
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
    }
}
