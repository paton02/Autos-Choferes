using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Modelos
{
    public class Registro
    {
        public int id { get; set; }
        public TipoRegistro tipoRegistro { get; set; }
        public DateTime fecha_vencimineto { get; set; }

        public Registro(int id, TipoRegistro tipoRegistro, DateTime fecha_vencimineto)
        {
            this.id = id;
            this.tipoRegistro = tipoRegistro;
            this.fecha_vencimineto = fecha_vencimineto;
        }
        public Registro() { }
    }
}
