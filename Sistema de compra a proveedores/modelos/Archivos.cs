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
                Usuario.ListUsuarios.Clear();

                FileStream fs = new FileStream("Usuarios.csv", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);


                string linea = "";
                string[] vLinea = new string[0];

                linea = sr.ReadLine();
                linea = sr.ReadLine();

                while (linea != null)
                {
                    vLinea = linea.Split(';');
                    

                    string nombre = vLinea[0];
                    string email = vLinea[1];
                    string password = vLinea[2];

                    Usuario user = new Usuario(nombre, email, password);
                    Usuario.ListUsuarios.Add(user);

                    linea = sr.ReadLine();
                }

                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }

        }
    }
}
