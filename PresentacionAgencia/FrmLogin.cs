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
        public FrmLogin()
        {
            mu = new ManejadorUsuario();
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ( mu.VerificarUsuario(new Usuario(txtNickname.Text, txtPassword.Text)) != null)
            {
                FrmMenu fm = new FrmMenu();
                fm.ShowDialog();
            }
            else
                MessageBox.Show("USUARIO NO ENCONTRADO");
            
        }
    }
}
