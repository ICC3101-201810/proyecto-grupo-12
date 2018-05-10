using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Persona : Usuario
    {
        string nombre, mail, carrera, numero, ocupacion;

        public Persona(string nombre, string mail, string carrera, string numero, string ocupacion, string uId, string contra, bool logedin) : base(uId, contra, logedin)
        {
            this.nombre = nombre;
            this.mail = mail;
            this.carrera = carrera;
            this.numero = numero;
            this.ocupacion = ocupacion;
        }
        
        public List<Persona> usuariosP = new List<Persona>();

        public bool AgregarUsuarioP (Persona p)
        {
            usuariosP.Add(p);
            return true;
        }

        public bool LogIn (string nom, string pass)
        {
            foreach (Persona p in usuariosP)
            {
                if ()
                {

                }
            }
        }
    }
}
