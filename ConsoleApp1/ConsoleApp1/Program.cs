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
            Persona pes1 = new Persona("emma Donoso", "emma@miuandes.cl", "ingenieria", "97096544", "estudiante", "260249967","12345");
            Persona pes2 = new Persona("juanito", "emma@miuandes.cl", "ingenieria", "97096544", "estudiante", "12345", "123456");
            ges.Base.Add(pes1);
            ges.Base.Add(pes2);
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

            

            
        }
    }
}
