using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Salas
    {
        string Horario, Cantidad;
        int IdSalas;
        public Salas(string hor, string cant, int idSalas)
        {
            Horario = hor;
            Cantidad = cant;
            IdSalas = idSalas;
        }
    }
}
