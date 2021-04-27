using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    class TiendaRopa
    {
        public List<Indumentaria> _inventario = new List<Indumentaria>();
        public List<Venta> _ventas = new List<Venta>();
        private int _ultimoCodigo;

        public int UltimoCodigo { get => _ultimoCodigo; set => _ultimoCodigo = value; }


    }
}
