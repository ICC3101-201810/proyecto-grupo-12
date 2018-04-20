using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public class Administrador : Usuario
        {
            string NombreAdmin, MailAdmin, Tipo;

            public Administrador(string nombre, string mail, string tipo, string uId, string contra) : base(uId, contra)
            {
                NombreAdmin = nombre;
                MailAdmin = mail;
                Tipo = tipo;
            }

        }
    
}

