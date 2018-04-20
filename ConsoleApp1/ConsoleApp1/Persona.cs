using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona : Usuario
    {
        public string Nombre, Email, Carrera, Numero, Ocupacion;

        public Persona(string nom, string mail, string car, string num, string ocu, string uId, string contra,string logins) : base(uId, contra,logins)
        {
            Nombre = nom;
            Email = mail;
            Carrera = car;
            Numero = num;
            Ocupacion = ocu;
        }

    }
}
