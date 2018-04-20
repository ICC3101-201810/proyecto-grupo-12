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
            Reserva res1 = new Reserva("cancha", "26/04", "15:00", "16:00", "emma Donoso");
            ges.ListaReserva.Add(res1);
            Persona pes1 = new Persona("emma Donoso", "emma@miuandes.cl", "ingenieria", "97096544", "estudiante", "260249967", "12345", "no");
            Persona pes2 = new Persona("juanito", "emma@miuandes.cl", "ingenieria", "97096544", "estudiante", "12345", "123456", "no");
            ges.Base.Add(pes1);
            ges.Base.Add(pes2);
            Console.Write("Bienvenidos a UANDES APP \n");
            Console.Write("Ingrese si tiene una cuenta(1), sino, registrese(2): \n");
            Console.Write("1)-> SIGN-IN \n");
            Console.Write("2)-> SIGN-UP \n");
            string opcion1;

            opcion1 = Convert.ToString(Console.ReadLine());
            if (opcion1 == "1")
            {
                ges.Login();
                ges.VerifyLogin();

            }
            if (opcion1 == "2")
            {
                ges.Registrarse();
            }

            Console.WriteLine(" \n --------------Menú----------- \n");
            foreach (Persona yu in ges.Base)
            {
                if (yu.LoginStatus == "si")
                {
                    string opcion2;
                    do
                    {
                        Console.WriteLine("Que Desea hacer " + yu.Nombre + "\n");
                        Console.Write("Desea Actualizar Info(1) \n");
                        Console.Write("Desea RESERVAR(2) \n");
                        Console.Write("Volver a este menu (3)");
                        opcion2 = Convert.ToString(Console.ReadLine());
                        if (opcion2 == "1")
                        { ges.Actualizar(yu); }
                        if (opcion2 == "2")
                        { ges.addRes(yu); }
                    }
                    while (opcion2 == "3");

                }
                Console.ReadKey();




            }
        }
    }
}
