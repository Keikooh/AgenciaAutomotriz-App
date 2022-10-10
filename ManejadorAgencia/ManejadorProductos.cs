using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccesoAgencia;
using EntidadesAgencia;

namespace ManejadorAgencia
{
    public class ManejadorProductos
    {
        AccesoProductos ap = new AccesoProductos();
        public void Guardar(Productos producto)
        {
            ap.Guardar(producto);
        }
    }
}
