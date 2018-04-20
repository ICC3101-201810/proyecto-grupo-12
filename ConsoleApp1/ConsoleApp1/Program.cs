using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gestor ges = new Gestor();
            Persona pes1 = new Persona("Johnny Donoso", "jadonoso2@miuandes.cl", "ingenieria", "97096544", "estudiante", "195287643","5436232");
            ges.Base.Add(pes1);
            Console.Write("Desea hacer SIGN-IN(1) o SIGN-UP(2): ");
            string opcion1;

            opcion1 = Convert.ToString(Console.ReadLine());
            if (opcion1 == "1")
            {
                ges.Login();
                ges.VerifyLogin();
                
            }
            if (opcion1=="2")
            {
                ges.Registrarse();
            }

            Console.Write()

            
        }
    }
}
