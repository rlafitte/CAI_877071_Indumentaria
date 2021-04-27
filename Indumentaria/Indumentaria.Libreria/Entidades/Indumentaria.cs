﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    abstract class Indumentaria
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
        internal TipoIndumentaria Tipo { get => _tipo; set => _tipo = value; }

        public string ToString()
        {
            return $"Código: {this.Codigo} - Stock: {this.Stock} unidades - Talle: {this.Talle} - Precio: ${this.Precio}";
        }
        protected virtual bool Equals(Indumentaria i)
        {
            Indumentaria aux = (Indumentaria)i;
            if (aux.Codigo == i.Codigo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected virtual string GetDetalle(/*Indumentaria I*/)
        {
            
            //Indumentaria aux = (Camisa)I;
            Camisa C = new Camisa();
            return C.GetDetalle();
            ///*return ""; //*/pendiente
        }
    }
}
