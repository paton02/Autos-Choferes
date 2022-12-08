using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Modelos
{
    public class Cliente
    {
        public int id { get; set; }
        public DatosPersonales personales { get; set; }

        public Cliente (int id, DatosPersonales personales)
        {
            this.id = id;
            this.personales = personales;
            
        }
        public Cliente() { }
        public override string ToString()
        {
            return $"Nombre: {this.personales.nombre} -Apellido:{this.personales.apellido} -Email:{this.personales.email}-Telefono:{this.personales.telefono}-DNI:{this.personales.dni} ";
        }
    }
}
