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
                datos.setearConsulta("select A.Codigo, A.Nombre, A.Descripcion, " +
                    "M.Descripcion AS Marca, C.Descripcion AS Categoria, A.ImagenUrl, A.Precio " +
                    "FROM ARTICULOS AS A " +
                    "JOIN CATEGORIAS AS C ON C.Id = A.IdCategoria " +
                    "JOIN MARCAS AS M ON M.Id = A.IdMarca");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector.GetString(0);
                    aux.Nombre = (string)datos.Lector.GetString(1);
                    aux.Descripcion = (string)datos.Lector.GetString(2);
                    aux.Marca = (string)datos.Lector.GetString(3);
                    aux.Categoria = (string)datos.Lector.GetString(4);
                    aux.UrlImagen = (string)datos.Lector.GetString(5);
                    aux.Precio = (decimal)datos.Lector.GetDecimal(6);
                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception)
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
