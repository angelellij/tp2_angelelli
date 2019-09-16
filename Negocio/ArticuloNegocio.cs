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
        public List<Articulo> getAll()
        {
            List<Articulo> articulos = new List<Articulo>();
            DB db = new DB();

            try
            {
                db.queryLectura("" +
                    "select a.Id, a.Codigo,a.Nombre, a.Descripcion, a.Imagen, a.Precio, a.IdMarca," +
                    " m.Descripcion DescripcionMarca, a.IdCategoria, c.Descripcion DescripcionCategoria " +
                    "from ARTICULOS a, MARCAS m, CATEGORIAS c " +
                    "where a.IdMarca = m.Id AND a.IdCategoria = c.id;");

                while (db.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.id = (int)db.Lector["Id"];
                    articulo.codigo = (string)db.Lector["codigo"];
                    articulo.nombre = (string)db.Lector["Nombre"];
                    articulo.descripcion = (string)db.Lector["Descripcion"]; 

                    articulo.marca = new Marca();
                    articulo.marca.id = (int)db.Lector["IdMarca"];
                    articulo.marca.descripcion = (string)db.Lector["DescripcionMarca"];

                    articulo.categoria = new Categoria();
                    articulo.categoria.id = (int)db.Lector["IdCategoria"];
                    articulo.categoria.descripcion = (string)db.Lector["DescripcionCategoria"];

                    articulo.imagen = (string)db.Lector["Imagen"];
                    articulo.precio = (decimal)db.Lector["Precio"];

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

        public void insert(Articulo articulo)
        {
            try
            {
                DB db = new DB();
                db.conexion();
                db.Comando.CommandText = "Insert into ARTICULOS values (" +
                    "'" + articulo.codigo + "'," +
                    "'" + articulo.nombre + "'," +
                    "'" + articulo.descripcion + "'," +
                    "'" + articulo.marca.id + "'," +
                    "'" + articulo.categoria.id + "'," +
                    "'" + articulo.imagen + "'," +
                    "'" + articulo.precio + "');";
                db.ejecutarEscritura();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public void update(Articulo articulo)
        {
            try
            {
                DB db = new DB();
                db.conexion();
                db.Comando.CommandText = "Update ARTICULOS set " +
                    "Codigo ='" + articulo.codigo + "'," +
                    "Nombre ='" + articulo.nombre + "'," +
                    "Descripcion ='" + articulo.descripcion + "'," +
                    "IdMarca ='" + articulo.marca.id + "'," +
                    "IdCategoria ='" + articulo.categoria.id + "'," +
                    "Imagen = '" + articulo.imagen + "'," +
                    "Precio ='" + articulo.precio + "' where id = " + articulo.id + ";";
                db.ejecutarEscritura();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Articulo articulo)
        {
            try
            {
                DB db = new DB();
                db.conexion();
                db.Comando.CommandText = "Delete from ARTICULOS where id = " + articulo.id + ";";
                db.ejecutarEscritura();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
