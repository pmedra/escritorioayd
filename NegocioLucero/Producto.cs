using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioLucero
{
   public class Producto
    {
        public int idproducto { get; set; }
        public int cantidad { get; set; }
        public Decimal precio { get; set; }

        public Producto() { 
        
        }

        public Producto(int idproducto, int cantidad, Decimal Precio) {

            this.idproducto = idproducto;
            this.cantidad = cantidad;
            this.precio = Precio;
        }



    }
}
