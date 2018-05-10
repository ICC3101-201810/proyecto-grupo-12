using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Canchas
    {
        string tipo, cId;
        DateTime horario;

        public Canchas (string tipo, string cId, DateTime horario)
        {
            this.tipo = tipo;
            this.cId = cId;
            this.horario = horario;
        }
    }
}
