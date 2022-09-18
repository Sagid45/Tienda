using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorTienda;
using EntidadTienda;

namespace PresentacionTienda
{
    public partial class frmProductosadd : Form
    {
        ManejadorProducto mp;
        public frmProductosadd()
        {           
            InitializeComponent();
            mp = new ManejadorProducto();
            if (frmproductos.product.idproducto > 0)
            {
                txtNombre.Text = frmproductos.product.nombre;
                txtDescripcion.Text = frmproductos.product.descripcion;
                txtPrecio.Text = frmproductos.product.precio.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mp.Guardar(new Productos(frmproductos.product.idproducto,
                txtNombre.Text, txtDescripcion.Text, int.Parse(txtPrecio.Text)));
            Close();
        }
    }
}
