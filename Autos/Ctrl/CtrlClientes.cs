using Autos.Datos;
using Autos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Ctrl
{
    public class CtrlClientes
    {
        DatosClientes datosClientes = new DatosClientes();
        Cliente cliente = new Cliente();
        
        public string Agregar(string nombre, string apellido, string email, string telefono, string dni)
        {
            if (nombre == "" || apellido == "" || email == "" || telefono == "" || dni == "")
            {
                return "Faltan completar campos";
            }
            else
            {
                if (datosClientes.Existe(dni) == true)
                {
                    return "El cliente ya existe";
                }
                else
                {
                   return datosClientes.Agregar(nombre, apellido, email, telefono, dni);
                   
                }
            }
        }
        public List<Cliente> Listar()
        {
             return datosClientes.Listar();
        }
    }
}
