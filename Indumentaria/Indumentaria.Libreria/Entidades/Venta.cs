using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    public class Venta
    {
        private List<VentaItem> _items/* = new List<VentaItem>()*/;
        private Cliente _c = new Cliente();
        
        private enum _estado
        {
            Iniciada,
            Procesada,
            Devuelto,
        }
        private int _codigo;
        public Venta()
        {
            _items = new List<VentaItem>();
            //_estado = _estado.Iniciada;
        }

        internal List<VentaItem> Items { get => _items; set => _items = value; }
        internal Cliente C { get => _c; set => _c = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }

        public double GetTotalPedido()
        {
            double d=0;
            foreach(VentaItem i in _items)
            {
                d += i.GetTotal();
            }
            return d;
        }
    }
}
