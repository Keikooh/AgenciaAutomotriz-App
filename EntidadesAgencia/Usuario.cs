using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAgencia
{
    public class Usuario
    {
        public Usuario(int idusuario, string password)
        {
            this.idusuario = idusuario;
            this.password = password;
        }

        public int idusuario { get; set; }
        public string password { get; set; }
    }
    
}
