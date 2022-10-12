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
        ManejadorProductos mp;

        public FrmProductos()
        {
            mu = new ManejadorUsuario();
            mp = new ManejadorProductos();
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            txtUserName.Text = mu.ObtenerNombre(FrmLogin.user);

            // ESCRITURA
            if (!FrmMenu.permisos.Contains('w'))    btnAgregar.Enabled = false;
            
            // LECTURA
            if (!FrmMenu.permisos.Contains('r'))    txtBuscar.Enabled = false;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddProductos fp = new FrmAddProductos();
            fp.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Actualizar()
        {
            mp.Mostrar(dtgProductos, txtBuscar.Text,
                FrmMenu.permisos.Contains("d") ? true : false,
                FrmMenu.permisos.Contains("u") ? true : false);
        }
    }
}
