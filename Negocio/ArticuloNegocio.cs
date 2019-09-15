using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public ArticuloNegocio () { }
        public List<Articulo> getListArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();
            DB db = new DB();

            try
            {
                db.ejecutarQuery("" +
                    "select a.Id, a.Codigo,a.Nombre, a.Descripcion, a.Imagen, a.Precio, a.IdMarca," +
                    " m.Descripcion DescripcionMarca, a.IdCategoria, c.Descripcion DescripcionCategoria " +
                    "from ARTICULOS a, MARCAS m, CATEGORIAS c " +
                    "where a.IdMarca = m.Id AND a.IdCategoria = c.id;");

                while (db.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.id = (int)db.Lector["Id"];
                    articulo.nombre = (string)db.Lector["Nombre"];
                    articulo.descripcion = (string)db.Lector["Descripcion"]; 

                    articulo.marca = new Marca();
                    articulo.marca.id = (int)db.Lector["IdMarca"];
                    articulo.marca.descripcion = (string)db.Lector["DescripcionMarca"];

                    articulo.categoria = new Categoria();
                    articulo.categoria.id = (int)db.Lector["IdCategoria"];
                    articulo.categoria.descripcion = (string)db.Lector["DescripcionCategoria"];

                    articulo.imagen = (string)db.Lector["imagen"];
                    articulo.id = (int)db.Lector["id"];

                    articulos.Add(articulo);
                    
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

            return articulos;
        }


    }
}
