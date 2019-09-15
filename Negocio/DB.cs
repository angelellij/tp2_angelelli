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
        public SqlCommand Comando { get; set; }
        public SqlConnection Conexion { get; set; }
        public SqlDataReader Lector { get; set; }

        public DB()
        {
           
        }

        public void conexion()
        {
            Conexion = new SqlConnection();
            Conexion.ConnectionString = "data source=DESKTOP-SC6KCBQ\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
            Comando = new SqlCommand();
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.Connection = Conexion;
        }
        public void queryLectura(string query)
        {
            conexion();
            Comando.CommandText = query;
            Conexion.Open();
            Lector = Comando.ExecuteReader();
        }

        public void ejecutarEscritura()
        {
            Conexion.Open();
            Comando.ExecuteNonQuery();
        }

        public void cerrarConeccion()
        {
            Conexion.Close();
        }
    }
    
}
