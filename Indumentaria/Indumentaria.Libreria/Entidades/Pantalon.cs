using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    public class Pantalon : Indumentaria

    {
        private string _material;
        private bool _tieneBolsillos;

        public string Material { get => _material; set => _material = value; }
        public bool TieneBolsillos { get => _tieneBolsillos; set => _tieneBolsillos = value; }

        public Pantalon()
        {
            TipoIndumentaria TI;
        }
        public override string GetDetalle()
        {
            return $"Material {this.Material} - Bolsillos {this.TieneBolsillos}";
        }
    }
}
