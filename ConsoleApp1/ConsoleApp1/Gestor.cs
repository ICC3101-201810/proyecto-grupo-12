using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Gestor
    {
        string usuario, contraseña,d;
        List<string> Reserva = new List<string>();
        List<string> CantCanchas = new List<string>();
        List<string> CantSalas = new List<string>();
        public List<Persona> Base = new List<Persona>();

        public Gestor()
        {

        }
        public void Registrarse()
        {
            string nom, mail, car, num, ocu, uId, contra;
            Console.WriteLine("Ingrese su nombre:   \n");
            nom = (Console.ReadLine());
            Console.WriteLine("Ingrese su mail:   \n");
            mail = (Console.ReadLine());
            Console.WriteLine("Ingrese su carrera:   \n");
            car = (Console.ReadLine());
            Console.WriteLine("Ingrese su telefono:   \n");
            num = (Console.ReadLine());
            Console.WriteLine("Ingrese su ocupacion(Estudiante, Empleado, etc):   \n");
            ocu = (Console.ReadLine());
            Console.WriteLine("Ingrese su USUARIO(RUT):   \n");
            uId = (Console.ReadLine());
            Console.WriteLine("Ingrese su CONTRASEÑA:   \n");
            contra = (Console.ReadLine());
            Persona p1 = new Persona(nom, mail, car, num, ocu, uId, contra);
            Base.Add(p1);
         
        }
        public void Login()
        {
            
            Console.Write("-----------Login-------------- \n");
            Console.Write("Ingrese su usuario: ");
            usuario = (Console.ReadLine());
            Console.Write("Ingrese su contraseña: ");
            contraseña = (Console.ReadLine());
            Console.Clear();
            
        }
        public void VerifyLogin()
        {
            foreach (Persona c in Base)
            {
                if(c.UsuarioID== usuario && c.Contrasena== contraseña)
                {
                    Console.Write("Bienvenido " + c.Nombre);
                }
                else { Console.Write("Acceso denegado"); }
            }
            Console.ReadKey();
        }

    }
}

