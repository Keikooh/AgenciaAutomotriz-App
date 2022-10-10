using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAgencia
{
    public class Usuario
    {
        public Usuario(string nickname, string password)
        {
            this.nickname = nickname;
            this.password = password;
        }

        public string nickname { get; set; }
        public string password { get; set; }
    }
    
}
