using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace WindowsFormsApp3
{
    [Serializable]
    public class Persona : Usuario
    {
        public string nombre, mail, carrera, numero;
        public enum Ocupacion { Administrador, Usuario };
        public Ocupacion ocupacion;
        public Persona(string nombre, string mail, string carrera, string numero, Ocupacion ocupacion, string uId, string contra, bool logedin) : base(uId, contra, logedin)
        {
            this.nombre = nombre;
            this.mail = mail;
            this.carrera = carrera;
            this.numero = numero;
            this.ocupacion = ocupacion;
        }

        public void AgregarUsuarioP (Persona p)
        {
            Controller.AddPersona(p);            
        }

        public Persona GetPersona(string uId, List<Persona> p)
        {
            foreach (Persona per in p)
            {
                if (per.uId == uId)
                {
                    return per;
                }
            }
            return null;
        }
    }
}
