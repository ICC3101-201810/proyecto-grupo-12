using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Froms
{
    class Controller
    {
        public List<Reserva> ReservasCancha;
        public List<Reserva> ReservasEstudio;
        Form5 Reservas1;

        public Controller(Form5 Reservas1)
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

    }
}
