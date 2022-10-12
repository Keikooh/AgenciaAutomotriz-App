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
    public partial class FrmProductos : Form
    {
        ManejadorUsuario mu;
        ManejadorProductos mp;
        public static Productos producto = new Productos(0, "", "", "");

        int fila = 0, columna = 0;  

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

        

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto.codigoBarras = int.Parse(dtgProductos.Rows[fila].Cells[0].Value.ToString());
            producto.nombre = dtgProductos.Rows[fila].Cells[1].Value.ToString();
            producto.descripcion = dtgProductos.Rows[fila].Cells[2].Value.ToString();
            producto.marca = dtgProductos.Rows[fila].Cells[3].Value.ToString();

            switch (columna)
            {
                case 4: { 
                        
                        DialogResult dr = MessageBox.Show(
                            String.Format("Desea eliminar '{0}'", producto.nombre),
                            "ATENCION",
                            MessageBoxButtons.YesNo); 

                        if (dr == DialogResult.Yes)
                            mp.Borrar(producto);

                        Actualizar();

                    } break;

                case 5: { } break;
            }
        }

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }


        void Actualizar()
        {
            mp.Mostrar(dtgProductos, txtBuscar.Text,
                FrmMenu.permisos.Contains("d") ? true : false,
                FrmMenu.permisos.Contains("u") ? true : false);
        }
    }
}
