using Autos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Datos
{
    public class DatosClientes
    {
        DatosConectar cnn = new DatosConectar();
        List<Cliente> lista_clientes = new List<Cliente>();

        public string Agregar(string nombre, string apellido, string email, string telefono, string dni)
        {
            try
            {
                cnn.Abrir();
                const string query = @"insert into DatosPersonales 
                                        values (@nombre,@apellido,@email,@telefono,@dni)";
                SqlCommand cmd = new SqlCommand(query, cnn.Conexion());
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.ExecuteNonQuery();
                cnn.Cerrar();
                int ultimoid = this.id_ultimo();
                cnn.Abrir();
                const string query2 = "insert into Clientes values (@id_Datos_Personales)";
                SqlCommand cmd2 = new SqlCommand(query2, cnn.Conexion());
                cmd2.Parameters.AddWithValue("@id_Datos_Personales",ultimoid);
                cmd2.ExecuteNonQuery();
                cnn.Cerrar();
                return "Agregado con exito";

            }
            catch (Exception ex)
            {
                cnn.Cerrar();
                return ex.Message;
            }
        }
        public bool Existe(string dni)
        {

            cnn.Abrir();
            string buscardni = "";
            const string query = "select dni from DatosPersonales where dni=@dni";
            SqlCommand cmd = new SqlCommand(query, cnn.Conexion());
            cmd.Parameters.AddWithValue("@dni", dni);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                buscardni = Convert.ToString(reader["dni"]);
            }
            cnn.Cerrar();
            if (buscardni == dni)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<Cliente> Listar()
        {
            cnn.Abrir();
            const string query = "select * from Clientes as C inner join DatosPersonales as D on C.id_Datos_Personales=D.id_DatosPersonales";
            SqlCommand cmd = new SqlCommand(query, cnn.Conexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Cliente clie = new Cliente
                {
                    id = Convert.ToInt32(reader["id_Datos_Personales"]),

                };
                DatosPersonales datos = new DatosPersonales
                {
                    id=Convert.ToInt32(reader["id_DatosPersonales"]),
                    nombre = Convert.ToString(reader["nombre"]),
                    apellido = Convert.ToString(reader["apellido"]),
                    email = Convert.ToString(reader["email"]),
                    telefono = Convert.ToString(reader["telefono"]),
                    dni = Convert.ToString(reader["dni"])
                };
                clie.personales = datos;
                lista_clientes.Add(clie);
            }
            cnn.Cerrar();
            return lista_clientes;
        }
        private int id_ultimo()
        {
            int id = 0;
            cnn.Abrir();
            string query = "select top 1 id_DatosPersonales from DatosPersonales order by id_DatosPersonales desc";
            SqlCommand cmd=new SqlCommand(query, cnn.Conexion());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["id_DatosPersonales"]);
            }
            cnn.Cerrar();
            return id;
        }
    }
}
