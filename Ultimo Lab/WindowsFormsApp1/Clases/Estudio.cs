using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    class Estudio
    {
        string nombre, direccion;
        DateTime fechaApert;

        public Estudio(string nombre, string direccion, DateTime fechaApert)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaApert = fechaApert;
        }
    }
}
