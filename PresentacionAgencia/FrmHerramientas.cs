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
    public partial class FrmHerramientas : Form
    {
        ManejadorUsuario mu;
        ManejadorHerramientas mh;

        int fila = 0, columna = 0;

        Herramientas herramienta = new Herramientas(0, "", "", "");

        public FrmHerramientas()
        {
            mu = new ManejadorUsuario();
            mh = new ManejadorHerramientas();
            InitializeComponent();
        }

        private void FrmHerramientas_Load(object sender, EventArgs e)
        {
            txtUserName.Text = mu.ObtenerNombre(FrmLogin.user);

            // ESCRITURA
            if (!FrmMenu.permisos.Contains('w')) btnAgregar.Enabled = false;

            // LECTURA
            if (!FrmMenu.permisos.Contains('r')) txtBuscar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddHerramientas fh = new FrmAddHerramientas();
            fh.ShowDialog();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Actualizar()
        {
            mh.Mostrar(txtBuscar.Text, dtgProductos,
                FrmMenu.permisos.Contains("d") ? true : false,
                FrmMenu.permisos.Contains("u") ? true : false
                );
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            herramienta.codigoHerramientas = int.Parse(dtgProductos.Rows[fila].Cells[0].Value.ToString());
            herramienta.nombre = dtgProductos.Rows[fila].Cells[1].Value.ToString();
            herramienta.medida = dtgProductos.Rows[fila].Cells[2].Value.ToString();
            herramienta.marca = dtgProductos.Rows[fila].Cells[3].Value.ToString();

            switch (columna)
            {
                case 4:
                    {

                        DialogResult dr = MessageBox.Show(
                            String.Format("Desea eliminar '{0}'", herramienta.nombre),
                            "ATENCION",
                            MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                            mh.Borrar( herramienta );

                        Actualizar();

                    }
                    break;

                case 5: { } break;
            }
        }

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }
    }
}
