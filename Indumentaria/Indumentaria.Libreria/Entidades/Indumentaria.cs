using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    public abstract class Indumentaria
    {
        private TipoIndumentaria _tipo;
        private int _codigo;
        private int _stock;
        private string _talle;
        private double _precio;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public string Talle { get => _talle; set => _talle = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public TipoIndumentaria Tipo { get => _tipo; set => _tipo = value; }
        public Indumentaria()
        {

        }
        public string ToString()
        {
            return $"Código: {this.Codigo} - Stock: {this.Stock} unidades - Talle: {this.Talle} - Precio por unidad: ${this.Precio}";
        }
        protected virtual bool Equals(Indumentaria i)
        {
            Indumentaria aux = (Pantalon)i;
            if (aux.Codigo == i.Codigo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public abstract string GetDetalle();
    }
}
