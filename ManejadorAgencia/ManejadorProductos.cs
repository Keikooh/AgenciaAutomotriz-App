using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoAgencia;
using EntidadesAgencia;
using Crud;

namespace ManejadorAgencia
{
    public class ManejadorProductos
    {
        AccesoProductos ap = new AccesoProductos();
        Grafica g = new Grafica();

        public void Guardar(Productos producto)
        {
            ap.Guardar(producto);
        }

        public void Editar(Productos producto)
        {
            ap.Editar(producto);
        }

        public void Borrar(Productos producto)
        {
            ap.Borrar(producto);
        }

        public void Mostrar(DataGridView tabla, string filtro, Boolean eliminacion, Boolean actualizacion)
        {
            tabla.Columns.Clear();
            tabla.DataSource = ap.Mostrar(filtro).Tables["productos"];
            tabla.RowTemplate.Height = 45;


            if (eliminacion) tabla.Columns.Insert(4, g.boton("eliminar", Color.Red));

            if (actualizacion) tabla.Columns.Insert(5, g.boton("editar", Color.Orange));


            tabla.Columns[0].Visible = false;
        }
    }
}
