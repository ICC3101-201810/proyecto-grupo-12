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
            comboBox1.Items.Add(Persona.Ocupacion.Administrador);
            comboBox1.Items.Add(Persona.Ocupacion.Usuario);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtNombre.Text;
            string userMail = txtMail.Text;
            string userCarrera = txtCarrera.Text;
            string userClave = txtClave.Text;
            string userRUT = txtRUT.Text;
            string userFono = txtFono.Text;

            if (comboBox1.SelectedItem != null)
            {
                string getOcupacion = comboBox1.SelectedItem.ToString();

                if (getOcupacion == (Persona.Ocupacion.Administrador).ToString())
                {
                    Persona a = new Persona(userName, userMail, userCarrera, userFono, Persona.Ocupacion.Administrador, userRUT, userClave, false);
                    a.AgregarUsuarioP(a);
                }

                else
                {
                    Persona a = new Persona(userName, userMail, userCarrera, userFono, Persona.Ocupacion.Usuario, userRUT, userClave, false);
                    a.AgregarUsuarioP(a);
                }

            }

            else
            {
                MessageBox.Show("Debe dejar claro cual es su ocupacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 openform1 = new Form1();
            openform1.Show();
            Visible = false;
        }

        private void txtRUT_TextChanged(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtRUT.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
