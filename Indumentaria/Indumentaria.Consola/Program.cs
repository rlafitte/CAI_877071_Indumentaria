using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Indumentaria.Libreria.Entidades;

namespace Indumentaria.Consola
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TiendaRopa TR = new TiendaRopa();
            Venta V = new Venta();
            Pantalon P = new Pantalon();
            Camisa Ca = new Camisa();
            Controlador C = new Controlador();

            while (TR.Ejecucion)
            {
                Console.WriteLine("Bienvenido a Tienda de Ropa");
                MostrarMenu();
                Menu(C.ValidaNumerico(Console.ReadLine()));
            }
        }
        public static void Menu(int i)
        {
            
            Console.WriteLine("Ingrese la opción deseada");
            switch (i)
            {
                case 0: 
                    break;

                default: break;
            }
        }
        static void MostrarMenu()
        {
            Console.WriteLine("1 - Listar Indumentarias" + Environment.NewLine +
                "2 - Agregar Indumentaria" + Environment.NewLine +
                "3 - Modificar Indumentaria" + Environment.NewLine +
                "4 - Eliminar Indumentaria" + Environment.NewLine +
                "5 - Listar ordenes" + Environment.NewLine +
                "6 - Ingresar Orden" + Environment.NewLine +
                "7 - Devolver Orden" + Environment.NewLine +
                "0 - Salir" + Environment.NewLine);
                //- Listar Indumentarias(GetDetalle())
                //- Agregar Indumentaria(por defecto cada indumentaria ingresa con 3 de stock)
                //- Modificar Indumentaria
                //- Eliminar Indumentaria
                //- Listar ordenes(con el formato "codigo) Apellido, Nombre Cliente, cantidad prendas, $ total pedido"
                //- Ingresar Orden(debe restar stock de la prenda seleccionada)
                //- Devolver Orden(debe volver al stock de la prenda)
                //- Cuando inicia la orden el estado es inciada
                //- Cuando el cliente deja de ingresar items el estado es prosada
                //- Cuando el cliente Devuelve el estado pasa a devuelto
                //- Se debe controlar los codigos de indumentaria con Equals
                //- ToString en Indumentaria devuelve GetDetalle
                //- GetDetalle se debe implemntar en Camisa y Pantalon.El template es a elección.
                //- Hacer las custom exceptions que sean necesarias
        }
        static void Salir()
        {
            
        }
    }
}
