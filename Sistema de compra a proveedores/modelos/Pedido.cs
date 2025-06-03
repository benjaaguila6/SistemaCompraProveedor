using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_compra_a_proveedores.Modelos
{
    public class Pedido : GenerarFactura
    {
        public static List<Pedido> ListPedido = new List<Pedido>();

        private int _codPedido;

		public int CodPedido
		{
			get { return _codPedido; }
			set { _codPedido = value; }
		}


		private DateTime _fEntrega;

		public DateTime FEntrega
		{
			get { return _fEntrega; }
			set { _fEntrega = value; }
		}

		private DateTime _fPedido;

		public DateTime FPedido
		{
			get { return _fPedido; }
			set { _fPedido = value; }
		}

		private bool _estado;

		public bool Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}

		private bool _pago;

		public bool Pago
		{
			get { return _pago; }
			set { _pago = value; }
		}

		private int _codProduct;

		public int CodProduct
		{
			get { return _codProduct; }
			set { _codProduct = value; }
		}

		private int _cantidad;

		public int Cantidad
		{
			get { return _cantidad; }
			set { _cantidad = value; }
		}

        public Pedido(int CodPedido, DateTime FEntrega , DateTime FPedido, bool Estado, bool Pago, int CodProduct, int Cantidad )
        {
			_codPedido = CodPedido;
			_fEntrega = FEntrega;
			_fPedido = FPedido;
			_estado = Estado;
			_pago = Pago;
        }
        public void generarFactura()
        {
            throw new NotImplementedException();
        }
    }
}
