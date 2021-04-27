using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facultad.Libreria;


namespace Facultad.Libreria
{
    public class Controlador
    {

        public List<object> _list = new List<object>();

        private bool flag=true;
        public bool Flag { get => flag; set => flag = value; }
        
        //public string AgregarObj(Object obj)
        //{

        //    Object B = _list.FirstOrDefault(o => o.dato == obj.dato);
        //    if (B.dato != null)
        //    {
        //        _list.Add(obj);
        //         return $"Registro {1} agregado correctamente.";
        //    }
        //    else
        //    {
        //         throw new InvalidOperationException();
        //    }
        //}
        //public string EliminarObj(Object obj)
        //{
        //    if (obj != null)
        //        _list.Remove(obj);
        //        return $"Registro {1} eliminado correctamente.";
        //    else
        //        throw new InvalidOperationException();
        //}
        public int ValidaNumerico(string s)
        {
            int i;
            if (int.TryParse(s, out i))
            {
                return i;
            }
            else
            {
                throw new ValorNoNumerico();
            }
        }

        //public void ValidaExistencia(int i)
        //{
        //    object obj;
        //    if (_list != null)
        //    {

        //    try
        //    {
        //        obj = _list.FirstOrDefault(o => o.dato == i);
        //        if (aux.Codigo != null)
        //        {
        //            throw new Exception();

        //        }
        //    }
        //    catch (NullReferenceException)
        //    {

        //    }
        //    }
        //}
        public string Listar()
        {
            string msg = "";
            foreach (Object obj in _list)
            {
                msg += (obj.ToString() + Environment.NewLine);
            }
            return msg;
        }
        //public string ToString()
        //{
        //    return $"{this.Dato}";
        //}
        //public override bool Equals(object obj)
        //{
        //    Object A = (Object)obj;
        //    if (A.dato == this._dato)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
