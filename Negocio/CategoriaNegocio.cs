using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public CategoriaNegocio() { }

        public List<Categoria> getAll()
        {

            List<Categoria> categorias = new List<Categoria>();
            DB db = new DB();

            try
            {
                db.queryLectura("" +
                    "select * from Categorias;");

                while (db.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.id = (int)db.Lector["Id"];
                    categoria.descripcion = (string)db.Lector["Descripcion"];

                    categorias.Add(categoria);

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



            return categorias;
        }
    }
}
