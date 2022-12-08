using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Datos
{
    public class DatosConectar
    {
        SqlConnection cnn = new SqlConnection("workstation id=AutosChoferes.mssql.somee.com;packet size=4096;user id=francuchi_SQLLogin_1;pwd=tlyyyen3jn;data source=AutosChoferes.mssql.somee.com;persist security info=False;initial catalog=AutosChoferes");
        public void Abrir()
        {
            cnn.Open();
        }
        public void Cerrar()
        {
            cnn.Close();
        }
        public SqlConnection Conexion()
        {
            return cnn;
        }
    }
}
