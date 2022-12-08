using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Datos
{
    public class DatosAutos
    {
        DatosConectar cnn = new DatosConectar();
        public string Agregar(string marca,string modelo,int anio,string patente)
        {
            try
            {
                cnn.Abrir();
                const string query = @"insert into Autos 
                                        values (@marca,@modelo,@anio,@patente)";
                SqlCommand cmd = new SqlCommand(query, cnn.Conexion());
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@anio",anio);
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.ExecuteNonQuery();
                cnn.Cerrar();
                return "Datos agregados correctamente";

            }
            catch (Exception ex)
            {
                cnn.Cerrar();
                return ex.Message;
            }
        }
        
    }
}
