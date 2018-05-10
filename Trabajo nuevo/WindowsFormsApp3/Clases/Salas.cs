using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Salas
    {
        string sId;
        int cantidad;
        DateTime horarios;

        public Salas(string sId, int cantidad, DateTime horarios)
        {
            this.sId = sId;
            this.cantidad = cantidad;
            this.horarios = horarios;
        }
    }
}
