﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    public class Director : Persona
    {
        public Director(string nombre, string apellido, DateTime fechaNac, string biografia) : base(nombre, apellido, fechaNac, biografia)
        {

        }
        public override string ReturnNombre()
        {
            return "";
        }
    }
}
