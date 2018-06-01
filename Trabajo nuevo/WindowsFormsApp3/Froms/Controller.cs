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

            BinaryFormatter formatter2 = new BinaryFormatter();
            Stream miStream2 = new FileStream("reservasCanchas.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter2.Serialize(miStream2, ReservasCancha);
            miStream2.Close();

            BinaryFormatter formatter3 = new BinaryFormatter();
            Stream miStream3 = new FileStream("reservasSalas.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter3.Serialize(miStream3, ReservasEstudio);
            miStream3.Close();
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
            if (File.Exists("reservasCanchas.txt"))
            {
                BinaryFormatter formatter2 = new BinaryFormatter();
                Stream miStream2 = new FileStream("reservasCanchas.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                ReservasCancha = (List<Reserva>)formatter2.Deserialize(miStream2);
                miStream2.Close();
            }
            if (File.Exists("reservasSalas.txt"))
            {
                BinaryFormatter formatter3 = new BinaryFormatter();
                Stream miStream3 = new FileStream("reservasSalas.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                ReservasEstudio = (List<Reserva>)formatter3.Deserialize(miStream3);
                miStream3.Close();
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
                            current = p;
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        public static void LogOut()
        {
            current = null;
        }

        public static Persona ReturnCurrent()
        {
            return current;
        } 

        public static void AddReserva(Reserva res)
        {
            if(res.Espacio=="Estudio")
            {
                ReservasEstudio.Add(res);
            }
            else
            {
                ReservasCancha.Add(res);
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
