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

        /*
        Form6 Reservas1;
        
        public Controller(Form6 Reservas1)
        {
            ReservasCancha = new List<Reserva>();
            ReservasEstudio = new List<Reserva>();
            Reserva res1 = new Reserva("Estudio", "12/05", "Sala 10", "195287643", "10:00-11:00");
            Reserva res2 = new Reserva("Cancha", "12/05", "Cancha 1", "195287643", "13:00-14:00");
            ReservasCancha.Add(res2);
            ReservasEstudio.Add(res1);
            this.Reservas1 = Reservas1;
            this.Reservas1.OnAgregarReserva += Registro1_OnAgregarReserva;
        }

        private void Registro1_OnAgregarReserva(object sender, AgregarReservaArgs e)
        {
            if (e.Espacio == "Estudio")
            {
                Reserva res = new Reserva(e.Espacio, e.Dia, e.Numero, e.IdReservista, e.Bloque);
                foreach (Reserva reservita in ReservasEstudio)
                {
                    if (ReservasCancha.Contains(res))
                    {
                        Reservas1.Remover(res.Bloque);
                        MessageBox.Show("no disponible");
                        break;
                    }
                    else
                    {
                        ReservasEstudio.Add(res);
                        MessageBox.Show("RESERVA HECHA");
                        break;
                    }
                }
            }
            if (e.Espacio == "Cancha")
            {
                Reserva res = new Reserva(e.Espacio, e.Dia, e.Numero, e.IdReservista, e.Bloque);
                foreach (Reserva reservita in ReservasCancha)
                {
                    if (ReservasCancha.Contains(res))
                    {
                        Reservas1.Remover(res.Bloque);
                        break;
                    }
                    else
                    {
                        ReservasCancha.Add(res);
                        break;
                    }
                }
            }
        }
        */
    }
}
