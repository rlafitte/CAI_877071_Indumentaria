using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Entidades
{
    public class Excepciones : Exception
    {

    }
    public class OperacionInvalida : Exception
    {
        public OperacionInvalida() : base("La opción no es válida.") { }
    }
    public class ValorNoNumerico: Exception
    {
        public ValorNoNumerico() : base("El valor ingresado no es numérico") { }
    }    
    public class AlumnoExistente: Exception
    {
        public AlumnoExistente() : base("El alumno ya existe") { }
    }    
    public class CodigoEmpleado: Exception
    {
        public CodigoEmpleado() : base("El codigo de empleado debe ser 1, 2, o 3") { }
    }
    public class SinStock: Exception
    {
        public SinStock() : base("No hay stock disponible") { }
    }
    public class PrendaInvalida: Exception
    {
        public PrendaInvalida() : base("Código de prenda inválido") { }
    }
    
}
