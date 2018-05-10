using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Reserva
    {
        string tipo, numero, rId;
        DateTime inicio, fin;

        public Reserva (string tipo, string numero, string rId, DateTime inicio, DateTime fin)
        {
            this.tipo = tipo;
            this.numero = numero;
            this.rId = rId;
            this.inicio = inicio;
            this.fin = fin;

        }
    }
}
