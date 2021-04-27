using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try 
	        {	        
                datos.setearConsulta("select Descripcion AS Marca FROM MARCAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca((string)datos.Lector["Marca"]);
                    lista.Add(aux);
                }
                return lista;
	        }
	        catch (global::System.Exception)
	        {
		        throw;
	        }
        }   
    }
}

