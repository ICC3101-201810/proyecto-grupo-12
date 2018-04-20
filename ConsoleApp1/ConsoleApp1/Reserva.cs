using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Reserva
    {
        public string Tipo, Dia, HoraInicio, HoraFin ,uid;
        

        public Reserva(string tipo, string dia, string inicio, string fin,string uid)
        {
            Tipo = tipo;
            Dia = dia;
            HoraInicio = inicio;
            HoraFin = fin;
            this.uid = uid;
        }


    }
}

