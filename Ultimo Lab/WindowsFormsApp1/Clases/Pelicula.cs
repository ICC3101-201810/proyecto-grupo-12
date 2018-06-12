using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    class Pelicula
    {
        string nombre, director, descripcion;
        int presupuesto;
        DateTime fechaEstr;

        public Pelicula(string nombre, string director, DateTime fechaEstr, string descripcion, int presupuesto, Estudio estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.fechaEstr = fechaEstr;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
        }
    }
}
