﻿namespace Sistema_de_compra_a_proveedores.Vistas
{
    partial class FormEmpresa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.misPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.misPedidosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(346, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem1});
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Usuario";
            // 
            // cerrarSesionToolStripMenuItem1
            // 
            this.cerrarSesionToolStripMenuItem1.Name = "cerrarSesionToolStripMenuItem1";
            this.cerrarSesionToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem1.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem1.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem1_Click);
            // 
            // misPedidosToolStripMenuItem
            // 
            this.misPedidosToolStripMenuItem.Name = "misPedidosToolStripMenuItem";
            this.misPedidosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.misPedidosToolStripMenuItem.Text = "Mis Pedidos";
            this.misPedidosToolStripMenuItem.Click += new System.EventHandler(this.misPedidosToolStripMenuItem_Click);
            // 
            // FormEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEmpresa";
            this.Text = "FormEmpresa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem1;
    }
}