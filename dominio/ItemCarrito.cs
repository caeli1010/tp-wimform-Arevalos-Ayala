﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
   public  class ItemCarrito
    {
        public int cantidad { get; set; }
        public Articulo producto { get; set; }
        public decimal subTotal { get; set; }
        public ItemCarrito() {
            cantidad = 1;
            
        }
        //public override Articulo GetArticulo()
        //{
        //    return producto;
        //}
    }
}
