using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadesAgencia;
using AccesoAgencia;
using System.Windows.Forms;
using System.Drawing;
using Crud;

namespace ManejadorAgencia
{
    public class ManejadorHerramientas
    {
        AccesoHerramientas ah = new AccesoHerramientas();
        Grafica g = new Grafica();

        public void Guardar(Herramientas herramienta)
        {
            ah.Guardar(herramienta);
        }

        public void Mostrar( string filtro, DataGridView tabla, Boolean eliminacion, Boolean actualizacion)
        {
            tabla.Columns.Clear();
            tabla.DataSource = ah.Mostrar(filtro).Tables["herramientas"];
            tabla.RowTemplate.Height = 45;
            tabla.Columns[0].Visible = false;

            if (eliminacion)    tabla.Columns.Insert(4, g.boton("eliminar", Color.Red));
            
            if (actualizacion)  tabla.Columns.Insert(5, g.boton("editar", Color.Orange));
           

        }
    }
}
