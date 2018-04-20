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
        public List<Reserva> ReservasApro1 = new List<Reserva>(); //canchas
        public List<Reserva> ReservasApro2 = new List<Reserva>(); //estudio

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
            string tipo,numero,dia,horaini,horafin,usuario1;
            Console.WriteLine("Ingrese tipo de espacio a reservar Estudio o Cancha:   \n");
            tipo= (Console.ReadLine());
            Console.WriteLine("Ingrese el número de el espacio a reservar Salas de estudio(1-40) y canchas(1-2)");
            numero = (Console.ReadLine());
            Console.WriteLine("Ingrese el dia a reservar:   \n");
            dia = (Console.ReadLine());
            Console.WriteLine("Ingrese hora inicio:   \n");
            horaini = (Console.ReadLine());
            Console.WriteLine("Ingrese su hora de fin:   \n");
            horafin = (Console.ReadLine());
            usuario1 = yo.Nombre;
            Console.Write("\n");
            Reserva res1 = new Reserva(tipo, numero, dia, horaini, horafin, usuario1);
            VerifyRes(res1);
            
        }
        public void VerifyRes(Reserva reserva)
        { 
            if (reserva.Tipo == "Cancha")
            {
                int contador2 = 0;
                foreach (Reserva r in ReservasApro1)
                {
                    if (r.Numero != reserva.Numero && r.HoraInicio != reserva.HoraInicio && r.HoraFin != reserva.HoraFin)
                    {
                        contador2 = 1;
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        contador2 = 0;
                        continue;
                    }
                }
                if (contador2 == 1)
                {
                    ReservasApro1.Add(reserva);
                    Console.WriteLine("Reserva hecha para un espacio de tipo " + reserva.Tipo + " " + reserva.Numero + "el día " + reserva.Dia + " con hora de inicio " + reserva.HoraInicio + " y hora de fin " + reserva.HoraFin + ". \n");
                }
                else { Console.WriteLine("No hay espacios disponibles para su requerimiento. \n "); }
            }
            if (reserva.Tipo == "Estudio")
            {
                int contador2 = 0;
                foreach (Reserva a in ReservasApro2)
                {
                    if (a.Numero != reserva.Numero && a.HoraInicio != reserva.HoraInicio && a.HoraFin != reserva.HoraFin)
                    {
                        contador2 = 1;
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        contador2 = 0;
                        continue;
                    }
                }
                if (contador2==1)
                {
                    ReservasApro2.Add(reserva);
                    Console.WriteLine("Reserva hecha para un espacio de tipo " + reserva.Tipo + " " + reserva.Numero + "el día " + reserva.Dia + " con hora de inicio " + reserva.HoraInicio + " y hora de fin " + reserva.HoraFin + "\n");
                }
                else { Console.WriteLine("No hay espacios disponibles para su requerimiento. \n "); }
            }
        }

        public void Mostrar()
        {
            string espacio,num;
            Console.WriteLine("Ingrese su espacio a buscar: \n");
            espacio = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese el número de espacio a buscar (Estudio=1-40 y Cancha= 1-2) ");
            num = Convert.ToString(Console.ReadLine());

            if (espacio == "Cancha")
            {
                foreach (Reserva res in ReservasApro1)
                {
                    if ( num == res.Numero)
                    {
                        Console.WriteLine("- " + res.Tipo + " = " + res.Numero + ". Dia: " + res.Dia + ". Hora Inicio: " + res.HoraInicio + ". Hora Fin: " + res.HoraFin +"\n");
                    }

                }
            }

            if (espacio== "Estudio")
            {
                foreach(Reserva res in ReservasApro2)
                {
                    if (num == res.Numero)
                    {
                        Console.Write("- " + res.Tipo + " = " + res.Numero + ". Dia: " + res.Dia + ". Hora Inicio: " + res.HoraInicio + ". Hora Fin: " + res.HoraFin +"\n");
                    }
                }
            }

        }
    }
}

