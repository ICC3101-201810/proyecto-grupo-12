using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Froms
{
    public class AgregarReservaArgs : EventArgs
    {
        public string Espacio { get; set; }
        public string Dia { get; set; }
        public string IdReservista { get; set; }
        public string Bloque { get; set; }
        public string Numero { get; set; }
    }
}
