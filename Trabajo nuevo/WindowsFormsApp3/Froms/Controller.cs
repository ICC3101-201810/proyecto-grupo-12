using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public static class Controller
    {
        
        private static List<Reserva> ReservasCancha;
        private static List<Reserva> ReservasEstudio;
        private static List<Persona> usuarios;
        private static Persona current;


        public static void Init()
        {
            ReservasCancha = new List<Reserva>();
            ReservasEstudio = new List<Reserva>();
            usuarios = new List<Persona>();
            Deserializar();
        }
        public static List<Reserva> GetReservasCancha()
        {
            return ReservasCancha;
        }

        public static List<Reserva> GetReservasEstudio()
        {
            return ReservasEstudio;
        }

        public static List<Persona> GetUsuarios()
        {
            return usuarios;
        }

        public static void AddPersona(Persona u)
        {
            usuarios.Add(u);
        }
        public static void Serializar()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream miStream = new FileStream("datosUsuarios.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(miStream, usuarios);
            miStream.Close();
        }
        private static void Deserializar()
        {
            if (File.Exists("datosUsuarios.txt"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream miStream = new FileStream("datosUsuarios.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                usuarios = (List<Persona>)formatter.Deserialize(miStream);
                miStream.Close();
            }
        }
        public static bool LogIn(Persona usu)
        {
            if (usuarios == null)
            {
                return false;
            }
            else
            {
                foreach (Persona p in usuarios)
                {
                    if (usu.nombre == p.nombre)
                    {
                        if (usu.contra == p.contra)
                        {
                            p.logedin = true;
                            usu = p;
                            current = p;
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        public static void LogOut(List<Persona> ps)
        {
            foreach (Persona p in ps)
            {
                if (p.logedin == true)
                {
                    p.logedin = false;
                }
            }
        }

        public static Persona ReturnCurrent()
        {
            return current;
        } 

        public static void AddReserva(Reserva res)
        {
            if(res.Espacio=="Estudio")
            {
                GetReservasEstudio().Add(res);
            }
            else
            {
                GetReservasCancha().Add(res);
            }
        }

        public static bool ComprobarReserva(Reserva res)
        {
            string espacio = res.Espacio;
            if (espacio=="Estudio")
            {
                foreach (Reserva reservita in GetReservasEstudio())
                {
                    if (res.Dia!= reservita.Dia && res.Bloque!= reservita.Bloque && res.Numero!= reservita.Numero)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            if (espacio == "Cancha")
            {
                foreach (Reserva reservita in GetReservasCancha())
                {
                    if (res.Dia != reservita.Dia && res.Bloque != reservita.Bloque && res.Numero != reservita.Numero)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
