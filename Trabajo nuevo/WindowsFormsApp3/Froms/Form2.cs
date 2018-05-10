using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtNombre.Text;
            string userMail = txtMail.Text;
            string userCarrera = txtCarrera.Text;
            string userOcupacion = txtOcupacion.Text;
            string userClave = txtClave.Text;
            string userRUT = txtRUT.Text;
            string userFono = txtFono.Text;

            Persona a = new Persona(userName, userMail, userCarrera, userFono, userOcupacion, userRUT, userClave, false);

            a.AgregarUsuarioP(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 openform1 = new Form1();
            openform1.Show();
            Visible = false;
        }
    }
}
