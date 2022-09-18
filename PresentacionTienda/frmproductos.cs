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
    public partial class frmproductos : Form
    {
        ManejadorProducto mp;
        public static Productos product = new Productos(0, "", "", 0);
        public static string paisa = "";
        int fila = 0, col = 0;
        public frmproductos()
        {
            InitializeComponent();
            mp = new ManejadorProducto();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            product.idproducto = -1;
            frmProductosadd arde = new frmProductosadd();
            arde.ShowDialog();
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            product.idproducto = int.Parse(dtgProductos.Rows[fila].
                Cells[0].Value.ToString());
            product.nombre = dtgProductos.Rows[fila].
                Cells[1].Value.ToString();
            product.descripcion = dtgProductos.Rows[fila].
                Cells[2].Value.ToString();
            product.precio = int.Parse(dtgProductos.Rows[fila].
                Cells[3].Value.ToString());

            switch (col)
            {
                case 6:
                    {
                        frmProductosadd prod = new frmProductosadd();
                        prod.ShowDialog();
                        Actualizar();
                    }
                    break;
                case 7:
                    {
                        mp.Borrar(product);
                        Actualizar();
                    }
                    break;
            }
        }

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        void Actualizar()
        {
            mp.Mostrar(dtgProductos, txtBuscar.Text);
        }
    }
}
