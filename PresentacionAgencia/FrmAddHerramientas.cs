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
    public partial class FrmAddHerramientas : Form
    {
        ManejadorHerramientas mh;
        public FrmAddHerramientas()
        {
            mh = new ManejadorHerramientas();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mh.Guardar(new Herramientas(0, txtNombre.Text, txtMedida.Text, txtMarca.Text));

            MessageBox.Show("PRODUCTO AGREGADO");

            Close();
        }
    }
}
