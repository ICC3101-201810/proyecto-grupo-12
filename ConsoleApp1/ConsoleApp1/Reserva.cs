using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Reserva
    {
        string Tipo, Dia, HoraInicio, HoraFin, Nombre;
        List<string> ListaAlum = new List<string>();

        public Reserva(string tipo, string dia, string inicio, string fin, string nom)
        {
            Tipo = tipo;
            Dia = dia;
            HoraInicio = inicio;
            HoraFin = fin;
            Nombre = nom;
        }

    }
}

