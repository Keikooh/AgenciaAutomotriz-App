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
    public partial class FrmMenu : Form
    {
        ManejadorUsuario mu;
        public static string permisos = "";
        public FrmMenu()
        {
            mu = new ManejadorUsuario();
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            VerificarPermisos(1, new FrmProductos());
        }

        private void btnHerramienta_Click(object sender, EventArgs e)
        {
            VerificarPermisos(2, new FrmHerramientas());
        }


        void VerificarPermisos(int idformulario, Form formulario)
        {
            permisos = mu.VerificarPermisos(FrmLogin.user, idformulario);

            if (permisos == null) 
                permisos = "";
            

            if (permisos != "")
                formulario.ShowDialog();
            else
                MessageBox.Show("NO SE ENCONTRARON PERMISOS");
        }

    }
}
