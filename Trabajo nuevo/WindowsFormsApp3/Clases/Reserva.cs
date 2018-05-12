﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Reserva
    {
        public string Espacio { get; set; }
        public string Dia { get; set; }// 26/04 ej de fecha
        public string IdReservista { get; set; }//RUT de quién hace la reserva
        public string Bloque { get; set; } // bloque de reserva(hora)
        public string Numero { get; set; } //Número Sala

        public Reserva(string espacio, string dia, string numero, string idReservista, string bloque)
        {
            this.Espacio = espacio;
            this.Dia = dia;
            this.Numero = numero;
            this.IdReservista = idReservista;
            this.Bloque = bloque;
        }

    }
}
