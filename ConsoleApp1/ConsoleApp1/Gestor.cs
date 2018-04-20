using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    public class Gestor
    {
        string usuario, contraseña;
        public List<Persona> Base = new List<Persona>();
        public List<Reserva> ListaReserva = new List<Reserva>();
        public List<Reserva> ReservasApro = new List<Reserva>();

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
            Persona p1 = new Persona(nom, mail, car, num, ocu, uId, contra,"si");
            Base.Add(p1);
         
        }
        public void Login()
        {
            
            Console.Write("-----------Login-------------- \n");
            Console.Write("\n");
            Console.Write("Ingrese su usuario: ");
            usuario = (Console.ReadLine());
            Console.Write("Ingrese su contraseña: ");
            contraseña = (Console.ReadLine());
            Console.Clear();
            
        }
        public void VerifyLogin()
        {
            int contador1=0;
            foreach (Persona c in Base)
            {
                if (usuario == c.UsuarioID)  
                {
                    if (contraseña == c.Contrasena)
                    {
                        Console.Write("Bienvenido " + c.Nombre + "\n");
                        c.LoginStatus = "si";
                        break;
                    } 
                }
                else
                {
                    contador1 = contador1 + 1;
                    continue;
                }
            }
            int c2 = Base.Count;
            if (contador1>=c2)
            {
                Console.Write("Acceso Denegado \n");
                Console.ReadKey();
            }
            
        }
        public void Actualizar(Persona yo)
        {
            Console.WriteLine("Ingrese su nombre:   \n");
            yo.Nombre = (Console.ReadLine());
            Console.WriteLine("Ingrese su mail:   \n");
            yo.Email = (Console.ReadLine());
            Console.WriteLine("Ingrese su carrera:   \n");
            yo.Carrera = (Console.ReadLine());
            Console.WriteLine("Ingrese su telefono:   \n");
            yo.Numero = (Console.ReadLine());
            Console.WriteLine("Ingrese su ocupacion(Estudiante, Empleado, etc):   \n");
            yo.Ocupacion = (Console.ReadLine());
            Console.WriteLine("Ingrese su USUARIO(RUT):   \n");
            yo.UsuarioID = (Console.ReadLine());
            Console.WriteLine("Ingrese su CONTRASEÑA:   \n");
            yo.Contrasena = (Console.ReadLine());

            Console.Write("Sus nuevos datos son, NOMBRE: " + yo.Nombre + " MAIL: " + yo.Email + " CARRERA: " + yo.Numero + " OCUPACION: " + yo.Ocupacion + " RUT: " + yo.UsuarioID);

        }

        public void addRes(Persona yo)
        {
            string tipo,dia,horaini,horafin,usuario1;
            Console.WriteLine("Ingrese tipo de espacio a reservar Estudios o Cancha:   \n");
            tipo= (Console.ReadLine());
            Console.WriteLine("Ingrese el dia a reservar:   \n");
            dia = (Console.ReadLine());
            Console.WriteLine("Ingrese hora inicio:   \n");
            horaini = (Console.ReadLine());
            Console.WriteLine("Ingrese su hora de fin:   \n");
            horafin = (Console.ReadLine());
            usuario1 = yo.Nombre;
            
            Reserva res1 = new Reserva(tipo,dia,horaini,horafin,usuario1);
            ListaReserva.Add(res1);
            VerifyRes(res1);
        }
        public void VerifyRes(Reserva reserva)
        {
            int contador2 = 0;
            foreach(Reserva r in ListaReserva)
            {
                if (reserva.Tipo== r.Tipo && reserva.Dia == r.Dia&& reserva.HoraInicio == r.HoraInicio)
                {
                    contador2 = contador2 + 1;
                    continue;
                }
                else
                {
                    ReservasApro.Add(reserva);
                    Console.Clear();
                    Console.WriteLine("Reserva hecha para un espacio de tipo "+reserva.Tipo+ " el día " + reserva.Dia + " con hora de inicio " + reserva.HoraInicio + " y hora de fin " + reserva.HoraFin+"\n");

                }
            }
            int c3 = ListaReserva.Count;
            if(contador2>= c3)
            {
                Console.Write("No hay reservas disponibles con su requerimiento. \n");
            }
           
        }
    }
}

