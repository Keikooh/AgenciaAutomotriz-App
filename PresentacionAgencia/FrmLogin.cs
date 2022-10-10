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
    public partial class FrmLogin : Form
    {
        ManejadorUsuario mu;

        public static Usuario user = new Usuario(0,"");

        public FrmLogin()
        {
            mu = new ManejadorUsuario();
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            user.idusuario = int.Parse(txtIdUsuario.Text);
            user.password = txtPassword.Text;

            if ( mu.VerificarUsuario( user ) != null)
            {
                FrmMenu fm = new FrmMenu();
                fm.ShowDialog();
            }
            else
                MessageBox.Show("USUARIO NO ENCONTRADO","ERROR");
            
        }
    }
}
