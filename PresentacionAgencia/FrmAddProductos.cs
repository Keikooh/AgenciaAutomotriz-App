using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ManejadorAgencia;
using EntidadesAgencia;

namespace PresentacionAgencia
{
    public partial class FrmAddProductos : Form
    {
        ManejadorProductos mp;
        public FrmAddProductos()
        {
            mp = new ManejadorProductos();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mp.Guardar(new Productos( 0,txtNombre.Text, txtDescripcion.Text, txtMarca.Text ));

            MessageBox.Show("PRODUCTO AGREGADO");

            Close();
        }
    }
}
