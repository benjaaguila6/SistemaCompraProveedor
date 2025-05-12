namespace Sistema_de_compra_a_proveedores
{
    partial class FormProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.btnModP = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codP,
            this.stock,
            this.precio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // codP
            // 
            this.codP.HeaderText = "ID";
            this.codP.Name = "codP";
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.inicioToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.infomesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // infomesToolStripMenuItem
            // 
            this.infomesToolStripMenuItem.Name = "infomesToolStripMenuItem";
            this.infomesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.infomesToolStripMenuItem.Text = "Infomes";
            this.infomesToolStripMenuItem.Click += new System.EventHandler(this.infomesToolStripMenuItem_Click);
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(354, 177);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(112, 23);
            this.btnAgregarP.TabIndex = 2;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            // 
            // btnModP
            // 
            this.btnModP.Location = new System.Drawing.Point(354, 206);
            this.btnModP.Name = "btnModP";
            this.btnModP.Size = new System.Drawing.Size(112, 23);
            this.btnModP.TabIndex = 3;
            this.btnModP.Text = "Modificar";
            this.btnModP.UseVisualStyleBackColor = true;
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Location = new System.Drawing.Point(354, 235);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(112, 23);
            this.btnEliminarP.TabIndex = 4;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.UseVisualStyleBackColor = true;
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.btnModP);
            this.Controls.Add(this.btnAgregarP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProduct";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codP;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infomesToolStripMenuItem;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Button btnModP;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}