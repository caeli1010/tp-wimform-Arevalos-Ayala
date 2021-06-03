using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    class StockNegocio
    {
        public List<Stock> Listar()
        {
            List<Stock> lista = new List<Stock>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta();
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    lista.Add();
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
