using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;


namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(@"SELECT
                                        A.Codigo,
                                        A.Nombre,
                                        A.Descripcion,
                                        M.Descripcion AS Marca,
                                        C.Descripcion AS Categoria,
                                        A.ImagenUrl AS Imagen,
                                        A.Precio,
                                        M.Id Mid,
                                        C.Id as Cid
                                        FROM
                                        ARTICULOS AS A
                                        JOIN CATEGORIAS AS C ON C.Id = A.IdCategoria
                                        JOIN MARCAS AS M ON M.Id = A.IdMarca");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.marca = new Marca((string)datos.Lector["Marca"]);
                    aux.categoria = new Categoria((string)datos.Lector["Categoria"]);
                    aux.UrlImagen = (string)datos.Lector["Imagen"];
                    aux.Precio = decimal.Round(datos.Lector.GetDecimal(6), 2, MidpointRounding.AwayFromZero);
                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = @"values('"+
                                    nuevo.Codigo+"', '"+ 
                                    nuevo.Nombre+"', '"+
                                    nuevo.Descripcion+ "', " +
                                    nuevo.marca.Id + ", " +
                                    nuevo.categoria.Id + ", '" +
                                    nuevo.UrlImagen+"', "+
                                    nuevo.Precio+ ")";
                datos.setearConsulta(@"insert into ARTICULOS (
                                        Codigo, 
                                        Nombre,
                                        Descripcion, 
                                        IdMarca, 
                                        IdCategoria, 
                                        ImagenUrl, 
                                        Precio
                                        ) " + valores);
                datos.ejecutarAccion();

            }
            catch (global::System.Exception)
            {
                throw;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string set = "Codigo ='" + modificar.Codigo + "', Nombre = '" + modificar.Nombre + "', Descripcion = '" + modificar.Descripcion + "', ImagenUrl = '" + modificar.UrlImagen + "', Precio = " + modificar.Precio + "";
                datos.setearConsulta("UPDATE ARTICULOS SET Descripcion = '" + modificar.Nombre + "' WHERE Codigo =" + modificar.Codigo + "");
                datos.ejecutarAccion();

            }
            catch (global::System.Exception)
            {
                throw;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from ARTICULOS where Codigo = '" + codigo + "'");
                datos.ejecutarAccion();

            }
            catch (global::System.Exception)
            {
                throw;
            }

            finally
            {
                datos.cerrarConexion();
            }

        }
        public void leerArticulo(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select * from ARTICULOS where id = " + id + "");
                datos.ejecutarLectura();

            }
            catch (global::System.Exception)
            {
                throw;
            }

            finally
            {
                datos.cerrarConexion();
            }

        }
    }
}
