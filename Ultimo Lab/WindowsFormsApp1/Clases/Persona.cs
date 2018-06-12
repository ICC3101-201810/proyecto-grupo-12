using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    public abstract class Persona
    {
        string nombre, apellido, biografia;
        DateTime fechaNac;
 
        public Persona(string nombre, string apellido, DateTime fechaNac, string biografia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.biografia = biografia;
        }

        public abstract string ReturnNombre();

    }
}
