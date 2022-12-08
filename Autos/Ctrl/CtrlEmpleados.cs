using Autos.Datos;
using Autos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Ctrl
{
    public class CtrlEmpleados
    {
        Empleado empleados = new Empleado();
        DatosEmpleados datosEmpleados = new DatosEmpleados();

        public string Agregar(string nombre, string apellido, string email, string telefono, string dni, string marca, string modelo, int anio, string patente,string tipo, string fecha_vencimiento)
        {
            if (nombre == "" || apellido == "" || email == "" || telefono == "" || dni == "" || marca == "" || modelo == "" || anio == 2005 || patente == "" || fecha_vencimiento == "")
            {
                return "Faltan completar campos";
            }
            else if (datosEmpleados.Existe(dni) == true)
            {
                return "El empleado ya existe";
            }
            else
            {
                return datosEmpleados.Agregar(nombre, apellido, email, telefono, dni, marca, modelo, anio, patente,tipo, fecha_vencimiento);
            }

        }

       public List<Empleado> Listar ()
        {
            return datosEmpleados.Listar();
        }

        internal List<string> traerTipos()
        {
            return datosEmpleados.traerTipos();
        }
    }
}
