using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    class VentaItem
    {
        private Indumentaria _prenda;
        private int _cantidad;

        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        internal Indumentaria Prenda { get => _prenda; set => _prenda = value; }

        public double GetTotal()
        {
            return (Cantidad * Prenda.Precio);
        }
    }
}
