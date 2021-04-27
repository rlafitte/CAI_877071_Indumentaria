using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    abstract class TipoIndumentaria
    {
        private string _origen;
        private double _porcentajeAlgodon;

        public string Origen { get => _origen; set => _origen = value; }
        public double PorcentajeAlgodon { get => _porcentajeAlgodon; set => _porcentajeAlgodon = value; }
    }
}
