using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Modelos
{
    public class DatosPersonales
    {
        public int id { get; set; }
        public string  nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string dni { get; set; }

        public DatosPersonales(int id,string nombre,string apellido,string email,string telefono,string dni)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.dni = dni;
        }
        public DatosPersonales() { }
    }
}
