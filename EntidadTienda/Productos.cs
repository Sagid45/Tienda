using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadTienda
{
    public class Productos
    {
        public Productos(int idproducto, string nombre, string descripcion, int precio)
        {
            this.idproducto = idproducto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public int idproducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
    }
}
