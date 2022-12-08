using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Modelos
{
    public class Auto
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int anio { get; set; }
        public string patente { get; set; }

        public Auto(int id,string marca,string modelo,int anio,string patente)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
            this.patente = patente;
        }
        public Auto() { }
    }
}
