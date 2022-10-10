using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadesAgencia;
using AccesoAgencia;

namespace ManejadorAgencia
{
    public class ManejadorHerramientas
    {
        AccesoHerramientas ah = new AccesoHerramientas();

        public void Guardar(Herramientas herramienta)
        {
            ah.Guardar(herramienta);
        }
    }
}
