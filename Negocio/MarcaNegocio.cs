using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {
        public MarcaNegocio() { }

        public List<Marca> getAll() {
            
            List<Marca> marcas = new List<Marca>();
            DB db = new DB();

            try
            {
                db.queryLectura("select * from Marcas;");

                while (db.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.id = (int)db.Lector["Id"];
                    marca.descripcion = (string)db.Lector["Descripcion"];

                    marcas.Add(marca);

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.cerrarConeccion();
            }



                return marcas;
        }
    }
}
