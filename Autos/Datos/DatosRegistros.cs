using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Datos
{
    public class DatosRegistros
    {
        DatosConectar cnn = new DatosConectar();
        
        public void Agregar(string tipo_registro,string fecha_vencimiento)
        {
            try
            {
                cnn.Abrir();
                const string query = @"insert into TipoRegistros 
                                        values (@tipo)";
                SqlCommand cmd = new SqlCommand(query, cnn.Conexion());
                cmd.Parameters.AddWithValue("@tipo",tipo_registro);
                cmd.ExecuteNonQuery();
                int ultimoid = this.id_ultimo();
                const string query2 = @"insert into Registro
                                        values (@id_TipoRegistros,@Fecha_Vencimiento)";
                SqlCommand cmd2 = new SqlCommand(query2, cnn.Conexion());
                cmd2.Parameters.AddWithValue("@id_TipoRegistros", ultimoid);
                cmd.Parameters.AddWithValue("@Fecha_Vencimiento", fecha_vencimiento);
                cmd2.ExecuteNonQuery();
                cnn.Cerrar();

            }
            catch (Exception )
            {
                cnn.Cerrar();
            }
        }
        private int id_ultimo()
        {
            int id = 0;
            cnn.Abrir();
            string query = "select top 1 id_DatosPersonales from DatosPersonales order by id_DatosPersonales desc";
            SqlCommand cmd = new SqlCommand(query, cnn.Conexion());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["id_DatosPersonales"]);
            }
            cnn.Cerrar();
            return id;
        }

        //public void AgregarR(string fecha_vencimineto)
        //{
        //    try
        //    {
        //        cnn.Abrir();
        //        const string query = @"insert into Registro 
        //                                values (@fecha_vencimiento)";
        //        SqlCommand cmd = new SqlCommand(query, cnn.Conexion());
        //        cmd.Parameters.AddWithValue("@fecha_vencimineto",fecha_vencimineto);
        //        cmd.ExecuteNonQuery();
        //        cnn.Cerrar();

        //    }
        //    catch (Exception)
        //    {
        //        cnn.Cerrar();
        //    }
        //}
    }
}
