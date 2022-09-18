using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;


namespace AccesoDatosTienda
{
    public class AccesoDatosProductos
    {
        Base b = new Base("Localhost", "root", "", "Tienda", 3306);

        public void Borrar(dynamic Entidad)
        {
            b.comando(String.Format("call deleteproducto({0})",
                Entidad.idproducto));

        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("call insertproducto(" +
              "'{0}','{1}','{2}',{3})", Entidad.idproducto,
                  Entidad.nombre, Entidad.descripcion, Entidad.precio));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
              (string.Format("call showproducto('%{0}%')",
                  filtro), "producto");
        }
    }
}
