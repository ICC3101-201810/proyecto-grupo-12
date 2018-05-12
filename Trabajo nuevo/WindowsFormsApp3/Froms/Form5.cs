using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Froms
{
    public partial class Form5 : Form
    {
        public enum Espacio { Estudio, Cancha };
        public event EventHandler<AgregarReservaArgs> OnAgregarReserva;
        public Form5()
        {

            InitializeComponent();
            this.cbEspacio.DataSource = Enum.GetValues(typeof(Espacio));

        }

        private void BtnASalas_Click(object sender, EventArgs e)
        {
            if (OnAgregarReserva != null)
            {
                AgregarReservaArgs reservaArgs = new AgregarReservaArgs();
                reservaArgs.Espacio = cbEspacio.Text;
                reservaArgs.Dia = cbDate.Value.Day.ToString() + "/" + cbDate.Value.Month.ToString();
                reservaArgs.IdReservista = "195287643";
                reservaArgs.Numero = cbNumero.Text;
                reservaArgs.Bloque = cbHorario.Text;
                OnAgregarReserva(this, reservaArgs);
            }
        }

        private void CbEspacio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNumero.Items.Clear();
            if (cbEspacio.Text == "Estudio")
            {
                for (int i = 1; i <= 40; i++)
                {
                    cbNumero.Items.Add("Sala " + i.ToString());
                }
            }
            else
            {
                for (int i = 1; i <= 2; i++)
                {
                    cbNumero.Items.Add("Cancha " + i.ToString());
                }
            }
        }
        public void Remover(string s)
        {
            cbNumero.Items.Remove(s);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}

