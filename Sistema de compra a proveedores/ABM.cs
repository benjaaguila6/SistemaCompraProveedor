using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_compra_a_proveedores
{
    public interface ABM
    {
        void Modificar(Producto p, int cod, int stock, decimal precio);
        void Agregar(Producto p);
        void Eliminar(Producto p);
    }
}
