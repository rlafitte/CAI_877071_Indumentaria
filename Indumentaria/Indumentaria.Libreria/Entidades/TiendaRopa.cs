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

        public TiendaRopa()
        {
            _inventario = new List<Indumentaria>();
            _ventas = new List<Venta>();
            _ultimoCodigo = 0;
        }
        public int UltimoCodigo { get => _ultimoCodigo; set => _ultimoCodigo = value; }

        public int GetProximoCodigo()
        {
            //ultimo codigo de ventas o de inventario?
            return (UltimoCodigo + 1);
        }
        public void Agregar(Indumentaria I)
        {

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
        public List<Indumentaria> Listar()
        {
            return _inventario;
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
