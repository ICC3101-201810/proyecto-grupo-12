using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Administrador : Usuario
    {
        string nombre, mail, tipo;

        public Administrador(string nombre, string mail, string tipo, string uId, string contra, bool logedin) : base(uId, contra, logedin)
        {
            this.nombre = nombre;
            this.mail = mail;
            this.tipo = tipo;
        }

    }
}
