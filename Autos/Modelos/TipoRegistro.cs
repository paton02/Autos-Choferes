using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Modelos
{
    public class TipoRegistro
    {
        public int id { get; set; }
        public string tipo { get; set; }

        public TipoRegistro(int id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
        }
    }
}
