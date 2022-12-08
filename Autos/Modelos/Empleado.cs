using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Modelos
{
    public class Empleado
    {
        public int id { get; set; }
        public Auto Auto { get; set; }
        public DatosPersonales Personales { get; set; }
        public Registro registro { get; set; }

        public Empleado(int id, Auto auto, DatosPersonales personales, Registro registro)
        {
            this.id = id;
            Auto = auto;
            Personales = personales;
            this.registro = registro;
        }
        public Empleado() { }
    }
}
