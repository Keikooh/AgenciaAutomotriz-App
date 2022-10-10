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

namespace PresentacionAgencia
{
    public partial class FrmProductos : Form
    {
        ManejadorUsuario mu;
        public FrmProductos()
        {
            mu = new ManejadorUsuario();
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            txtUserName.Text = mu.ObtenerNombre(FrmLogin.user);

            if (!FrmMenu.permisos.Contains('w')) 
            { 
                btnAgregar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddProductos fp = new FrmAddProductos();
            fp.ShowDialog();
        }
    }
}
