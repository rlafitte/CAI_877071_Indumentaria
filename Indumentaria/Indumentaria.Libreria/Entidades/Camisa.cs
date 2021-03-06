using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    public class Camisa : Indumentaria
    {
        private string _tipoManga;
        private bool _tieneEstampado;

        public string TipoManga { get => _tipoManga; set => _tipoManga = value; }
        public bool TieneEstampado { get => _tieneEstampado; set => _tieneEstampado = value; }

        public override string GetDetalle()
        {
            return $"Tipo de manga: {this.TipoManga} - Estampado: {this.TieneEstampado}";
        }
    }
}
