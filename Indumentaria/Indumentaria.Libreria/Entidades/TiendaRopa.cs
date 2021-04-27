using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    public class TiendaRopa
    {
        public List<Indumentaria> _inventario/* = new List<Indumentaria>()*/;
        public List<Venta> _ventas/* = new List<Venta>()*/;
        private int _ultimoCodigo;
        private bool _ejecucion;

        public TiendaRopa()
        {
            _inventario = new List<Indumentaria>();
            _ventas = new List<Venta>();
            _ultimoCodigo = 0;
            _ejecucion = true;
        }
        public int UltimoCodigo { get => _ultimoCodigo; set => _ultimoCodigo = value; }
        public bool Ejecucion { get => _ejecucion; set => _ejecucion = value; }

        public int GetProximoCodigo()
        {
            int _ultimo = 0;
            if (_inventario.Count == 0)
            {
                return 1;
            }
            else
            {

                foreach (Indumentaria i in _inventario)
                {
                    _ultimo += 1;
                }
                _ultimo += 1;
                return _ultimo;
                {

                }

            }
        }
        public void Agregar(Indumentaria I)
        {
            I.Codigo = GetProximoCodigo();
            _inventario.Add(I);
        }
        public void Modificar(Indumentaria I)
        {

        }
        public void Quitar(Indumentaria I)
        {

        }
        public void IngresarOrden(Venta V)
        {

        }
        public string Listar()
        {
            string msg = "";
            foreach(Indumentaria I in _inventario)
            {
                msg += I.ToString() + Environment.NewLine;
            }
            return msg; ;
            

        }
        public List<Venta> ListarOrden()
        {
            return _ventas;
        }
        public void DevolverOrden(Venta V)
        {

        }
    }
}
