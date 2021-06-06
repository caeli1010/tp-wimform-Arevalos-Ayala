using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Carrito
    {
        public decimal Total { get; set; }
        public List<ItemCarrito> Itemcarrito { get; set; }
    }
}
