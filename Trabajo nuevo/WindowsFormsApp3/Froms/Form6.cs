using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace WindowsFormsApp3.Froms
{
    public partial class Form6 : Form
    {
        Form3 parent;
        
        public Form6(Form3 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void BtnASalas_Click(object sender, EventArgs e)
        {
            string espacio = cbEspacio.Text;
            string fecha = cbHorario.Text;
            string horario = cbHorario.Text;
            string numeroesp = cbNumero.Text;

            Reserva res = new Reserva(espacio, fecha, numeroesp, null, horario);

            if (Controller.ComprobarReserva(res) == true)
            {
                Controller.AddReserva(res);
                MessageBox.Show("Reserva hecha");
            }
            else
            {
                MessageBox.Show("Reserva no disponible, por favor elegir otro día, otro Bloque o sala");
            }
        }

        private void cbEspacio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEspacio.Text == "Estudio")
            {
                this.cbNumero.Items.AddRange(new object[] {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",
                "24",
                "25",
                "26",
                "27",
                "28",
                "29",
                "30",
                "31",
                "32",
                "33",
                "34",
                "35",
                ""});
            }
            if (cbEspacio.Text == "Cancha")
            {
                this.cbNumero.Items.AddRange(new object[] {
                    "Cancha 1",
                    "Cancha 2",
                });
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            parent.Show();
            base.OnClosed(e);
        }

    }
}
