using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_compra_a_proveedores.Modelos
{
    public class Archivos
    {
        public void cargaUsuarios()
        {
            try
            {
                FileStream fs = new FileStream("Usuarios.csv", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string linea = "";
                string[] vLinea = new string[0];

                linea = sr.ReadLine();

                while (linea != null)
                {
                    vLinea = linea.Split(';');
                    string nombre = vLinea[0];
                    string email = vLinea[1];
                    string password = vLinea[2];
                    string rol = vLinea[3];

                    Usuario user = new Usuario(nombre, email, password, rol);
                    Usuario.ListUsuarios.Add(user);

                    linea = sr.ReadLine();
                }

                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }
        public void cargaPedidos()
        {
            try
            {
                FileStream fsP = new FileStream("Pedidos.csv", FileMode.Open, FileAccess.Read);
                StreamReader srP = new StreamReader(fsP);

                string lineaP = "";
                string[] vecP = new string[0];

                lineaP = srP.ReadLine();



                while (lineaP != null)
                {
                    vecP = lineaP.Split(';');

                    int codPe = Convert.ToInt16(vecP[0]);
                    DateTime fentrega = DateTime.Parse(vecP[1]);
                    DateTime fpedido = DateTime.Parse(vecP[2]);
                    bool estado = bool.Parse(vecP[3]);
                    bool pago = bool.Parse(vecP[4]);
                    int codProd = Convert.ToInt16(vecP[5]);
                    int cant = Convert.ToInt16(vecP[6]);


                    Pedido pedido = new Pedido(codPe, fentrega, fpedido, estado, pago, codProd, cant);
                    Pedido.ListPedido.Add(pedido);

                    lineaP = srP.ReadLine();
                }

                fsP.Close();
                srP.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        public void escribirArchivo(string archi)
        {
            try
            {
                FileStream fs = new FileStream(archi, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                //register
                switch (archi)
                {
                    case "Usuarios.csv":
                        foreach (Usuario user in Usuario.ListUsuarios)
                        {
                            string linea = $"{user.Name};{user.Email};{user.Password}";
                            sw.WriteLine(linea);

                        }
                        break;

                    //agregar o modificar producto
                    case "Producto.csv":
                        foreach (Producto produ in Producto.ListProduct)
                        {
                            string linea = $"{produ.CodProducto};{produ.Stock};{produ.Precio}";
                            sw.WriteLine(linea);

                        }
                        break;
                }

                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al escribir archivo: " + ex.Message);
            }

        }

        public void cargarProductos(string archi)
        {
            try
            {
                FileStream fsP = new FileStream(archi, FileMode.Open, FileAccess.Read);
                StreamReader srP = new StreamReader(fsP);

                string lineaP = "";
                string[] vecP = new string[0];

                lineaP = srP.ReadLine();

                Producto.ListProduct.Clear();



                while (lineaP != null)
                {
                    vecP = lineaP.Split(';');

                    Producto producto = new Producto(int.Parse(vecP[0]), int.Parse(vecP[1]), decimal.Parse(vecP[2]));
                    Producto.ListProduct.Add(producto);

                    lineaP = srP.ReadLine();
                }

                fsP.Close();
                srP.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos" + ex.Message);
            }
        }
    }
}
