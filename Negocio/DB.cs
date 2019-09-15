using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    class DB
    {
        public SqlCommand Comando = new SqlCommand();
        public SqlConnection Conexion { get; set; }
        public SqlDataReader Lector { get; set; }

        public DB()
        {
           
        }

        public void ejecutarQuery(string query)
        {
            Conexion = new SqlConnection();
            Conexion.ConnectionString = "data source=DESKTOP-SC6KCBQ\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
            Comando = new SqlCommand();
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = query;
            Comando.Connection = Conexion;
            Conexion.Open();
            Lector = Comando.ExecuteReader();
        }

        public void cerrarConeccion()
        {
            Conexion.Close();
        }
    }
    
}
