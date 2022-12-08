using Autos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Datos
{
    public class DatosEmpleados
    {
        DatosConectar cnn = new DatosConectar();
        List<Empleado> lista_empleados = new List<Empleado>();

        public string Agregar(string nombre, string apellido, string email, string telefono, string dni, string marca, string modelo, int anio, string patente, string tipo, string fecha_vencimiento)
        {
            try
            {
                cnn.Abrir();
                const string query = @"insert into DatosPersonales 
                                        values (@nombre,@apellido,@email,@telefono,@dni)";
                SqlCommand cmd = new SqlCommand(query, cnn.Conexion());
                cmd.Parameters.AddWithValue("@nombre", tipo);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.ExecuteNonQuery();

                string query3 = @"insert into Autos values (@marca,@modelo,@anio,@patente)";
                SqlCommand cmd3 = new SqlCommand(query3, cnn.Conexion());
                cmd3.Parameters.AddWithValue("@marca", marca);
                cmd3.Parameters.AddWithValue("@modelo", marca);
                cmd3.Parameters.AddWithValue("@anio", anio);
                cmd3.Parameters.AddWithValue("@patente", patente);
                cmd3.ExecuteNonQuery();

                string query4 = $@"insert into Registro values ((select top 1 id_Tipo from TipoRegistros where tipo='{tipo}' order by id_Tipo asc),@Fecha_Vencimiento)";
                SqlCommand cmd4 = new SqlCommand(query4, cnn.Conexion());
                cmd4.Parameters.AddWithValue("@Fecha_Vencimiento", fecha_vencimiento);
                //  cmd4.Parameters.AddWithValue("@tipo", tipo);
                cmd4.ExecuteNonQuery();
                cnn.Cerrar();
                List<int> ids = this.idsEmpleado();
                cnn.Abrir();
                const string query2 = "insert into Empleados values (@id_DatosPersonales,@id_Autos,@id_Registro)";
                SqlCommand cmd2 = new SqlCommand(query2, cnn.Conexion());
                cmd2.Parameters.AddWithValue("@id_DatosPersonales", ids[0]);
                cmd2.Parameters.AddWithValue("@id_Autos", ids[1]);
                cmd2.Parameters.AddWithValue("@id_Registro", ids[2]);
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

        internal List<string> traerTipos()
        {
            cnn.Abrir();
            List<string> tipos = new List<string>();
            string query = "select tipo from TipoRegistros";
            SqlCommand cmd = new SqlCommand(query, cnn.Conexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tipos.Add(Convert.ToString(reader["tipo"]));
            }
            cnn.Cerrar();
            return tipos;
        }

        public List<Empleado> Listar()
        {
            cnn.Abrir();
            const string query = @"select * from Empleados inner join DatosPersonales on DatosPersonales.id_DatosPersonales=Empleados.id_DatosPersonales
						inner join Autos on Autos.id_auto=Empleados.id_Autos
						inner join Registro on Registro.id_Registros=Empleados.id_Registro ";
            SqlCommand cmd = new SqlCommand(query, cnn.Conexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Empleado empleado = new Empleado
                {
                    id = Convert.ToInt32(reader["id_Datos_Personales"]),

                };
                DatosPersonales datos = new DatosPersonales
                {
                    id = Convert.ToInt32(reader["id_DatosPersonales"]),
                    nombre = Convert.ToString(reader["nombre"]),
                    apellido = Convert.ToString(reader["apellido"]),
                    email = Convert.ToString(reader["email"]),
                    telefono = Convert.ToString(reader["telefono"]),
                    dni = Convert.ToString(reader["dni"])
                };
                Registro registro = new Registro
                {
                    id = Convert.ToInt32(reader["id_registro"]),
                    //tipoRegistro = Convert.ToString(reader["tipo"]),
                    fecha_vencimineto = Convert.ToDateTime(reader["Fecha_Vencimiento"])
                };
                Auto auto = new Auto
                {
                    marca = Convert.ToString(reader["marca"]),
                    modelo = Convert.ToString(reader["modelo"]),
                    anio = Convert.ToInt32(reader["anio"]),
                    patente = Convert.ToString(reader["patente"])
                };
                empleado.Auto = auto;
                empleado.registro = registro;
                empleado.Personales = datos;
                lista_empleados.Add(empleado);
            }
            cnn.Cerrar();
            return lista_empleados;
        }

        private List<int> idsEmpleado()
        {
            List<int> ids = new List<int>();
            cnn.Abrir();
            string query = @"select top 1 id_DatosPersonales from DatosPersonales order by id_DatosPersonales desc
                             select top 1 id_auto from Autos order by id_auto desc
                             select top 1 id_Registros from Registros order by id_Registros desc";
            SqlCommand cmd = new SqlCommand(query, cnn.Conexion());
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                int iddp = Convert.ToInt32(reader["id_DatosPersonales"]);
                int idauto = Convert.ToInt32(reader["id_auto"]);
                int idreg = Convert.ToInt32(reader["id_Registros"]);
                ids.Add(iddp);
                ids.Add(idauto);
                ids.Add(idreg);
            }
            cnn.Cerrar();
            return ids;
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
        public int TipoRegistro()
        {
            return 0;
        }


    }
}
