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
    public partial class FrmHerramientas : Form
    {
        ManejadorUsuario mu;
        public FrmHerramientas()
        {
            mu = new ManejadorUsuario();
            InitializeComponent();
        }

        private void FrmHerramientas_Load(object sender, EventArgs e)
        {
            txtUserName.Text = mu.ObtenerNombre(FrmLogin.user);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddHerramientas fh = new FrmAddHerramientas();
            fh.ShowDialog();

        }
    }
}
