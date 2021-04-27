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
        static private TiendaRopa TR;
        static private Venta V;
        static private Pantalon P;
        static private Camisa Ca;
        static private Controlador C;
        static private TipoIndumentaria TI;
        static int _aux;
        static Program()
        {
            TR = new TiendaRopa();
            V = new Venta();
            P = new Pantalon();
            Ca = new Camisa();
            C = new Controlador();

        }
        public static void Main(string[] args)
        {

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
                    Salir();
                    break;
                case 1:
                    Console.WriteLine(TR.Listar());
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Ingrese 1 para pantalón, 2 para camisa");
                        _aux = C.TipoPrenda(Console.ReadLine());
                        if (_aux == 1)
                        {
                            TR.Agregar(PedirDatosPantalon());
                        }
                        if (_aux == 2)
                        {
                            TR.Agregar(PedirDatosCamisa());
                        }
                        
                        
                    }
                    catch (PrendaInvalida p)
                    {
                        Console.WriteLine(p.Message);
                    }
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
        static Pantalon PedirDatosPantalon()
        {
                //Console.WriteLine("Ingrese el código de pantalón");
                //P.Codigo = C.ValidaNumerico(Console.ReadLine());
                Console.WriteLine("Ingrese el stock");
                P.Stock = C.ValidaNumerico(Console.ReadLine());
                if (P.Stock == 0)
                      {
                          P.Stock = 3; //por definición
                      }
                 
                Console.WriteLine("Ingrese el talle");
                P.Talle = Console.ReadLine();
                Console.WriteLine("Ingrese el precio");
                P.Precio = C.ValidaDouble(Console.ReadLine());
                Console.WriteLine("Ingrese origen de la prenda");
                TI = new IndumentariaCasual();
                P.Tipo = TI;
                P.Tipo.Origen = Console.ReadLine();
                Console.WriteLine("Ingrese porcentaje de algodón");
                P.Tipo.PorcentajeAlgodon = C.ValidaDouble(Console.ReadLine());
            return P;
            }        
        static Camisa PedirDatosCamisa()
        {
                //Console.WriteLine("Ingrese el código de camisa");
                //Ca.Codigo = C.ValidaNumerico(Console.ReadLine());
                Console.WriteLine("Ingrese el stock");
            Ca.Stock = C.ValidaNumerico(Console.ReadLine());
            if (Ca.Stock == 0)
            {
                Ca.Stock = 3; //por definición
            }

            Console.WriteLine("Ingrese el talle");
                Ca.Talle = Console.ReadLine();
                Console.WriteLine("Ingrese el precio");
                Ca.Precio = C.ValidaDouble(Console.ReadLine());
                Console.WriteLine("Ingrese origen de la prenda");
            TI = new IndumentariaCasual();
            Ca.Tipo = TI;
            Ca.Tipo.Origen = Console.ReadLine();
                Console.WriteLine("Ingrese porcentaje de algodón");
                Ca.Tipo.PorcentajeAlgodon = C.ValidaDouble(Console.ReadLine());
            return Ca;
            }
        static void Salir()
        {
            TR.Ejecucion = false;
        }

    }
    }

