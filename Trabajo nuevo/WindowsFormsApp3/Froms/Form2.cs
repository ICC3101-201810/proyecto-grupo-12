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
        List<Persona> usuariosP;

        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add(Persona.Ocupacion.Administrador);
            comboBox1.Items.Add(Persona.Ocupacion.Usuario);
            (new Persona("", "", "", "", Persona.Ocupacion.Usuario, "", "", false)).ListasUsuarios(usuariosP);
        }

        public void ListasUsuarios(List<Persona> ps)
        {
            ps = usuariosP;
        }

        public List<Persona> GetListaUsuarios()
        {
            return usuariosP;
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

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre,"Debe ingresar su nombre");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (txtRUT.Text == "")
            {
                errorProvider2.SetError(txtRUT, "Debe ingresar un RUT valido");
            }
            else
            {
                errorProvider2.Clear();
            }
            if (txtClave.Text == "")
            {
                errorProvider3.SetError(txtClave, "ingrese una contraseña valida (Mayor a un caracter)");
            }
            else
            {
                errorProvider3.Clear();
            }
            if (txtMail.Text == "")
            {
                errorProvider4.SetError(txtMail,"Ingrese un mail valido");
            }
            else
            {
                errorProvider4.Clear();
            }
            if (txtCarrera.Text == "")
            {
                errorProvider6.SetError(txtCarrera, "Ingrese su la carrera que esta cursando");
            }
            else
            {
                errorProvider6.Clear();
            }
            if (txtFono.Text == "")
            {
                errorProvider7.SetError(txtFono, "Ingrese su numero de contacto");
            }
            else
            {
                errorProvider7.Clear();
            }


            if (comboBox1.SelectedItem != null)
            {
                string getOcupacion = comboBox1.SelectedItem.ToString();
                errorProvider5.Clear();

                if (getOcupacion == (Persona.Ocupacion.Administrador).ToString())
                {
                    Persona a = new Persona(userName, userMail, userCarrera, userFono, Persona.Ocupacion.Administrador, userRUT, userClave, false);
                    usuariosP.Add(a);
                    a.ListasUsuarios(usuariosP);
                }

                else
                {
                    Persona a = new Persona(userName, userMail, userCarrera, userFono, Persona.Ocupacion.Usuario, userRUT, userClave, false);
                    usuariosP.Add(a);
                    a.ListasUsuarios(usuariosP);
                }

            }

            else
            {
                errorProvider5.SetError(comboBox1, "Debe ingresar una ocupacion");
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
