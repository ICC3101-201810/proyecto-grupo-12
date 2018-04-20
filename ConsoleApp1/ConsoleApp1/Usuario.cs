using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Usuario
        {
          public string UsuarioID, Contrasena,LoginStatus;

            public Usuario(string uId, string contra,string logins)
            {
                UsuarioID = uId;
                Contrasena = contra;
                LoginStatus = logins;

            }

        }
    
}
