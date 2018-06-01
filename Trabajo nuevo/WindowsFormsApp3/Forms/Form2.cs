using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        List<Persona> usuariosP;
        Persona p;
        Form1 parent;
        public Form2(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
            comboBox1.Items.Add(Persona.Ocupacion.Administrador);
            comboBox1.Items.Add(Persona.Ocupacion.Usuario);
            usuariosP = new List<Persona>();
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

            BinaryFormatter formatter = new BinaryFormatter();
            Stream miStream = new FileStream("datosUsuarios.txt",FileMode.Create,FileAccess.Write, FileShare.None);

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
                    formatter.Serialize(miStream, usuariosP);
                    miStream.Close();
                }
                else
                {
                    Persona a = new Persona(userName, userMail, userCarrera, userFono, Persona.Ocupacion.Usuario, userRUT, userClave, false);
                    usuariosP.Add(a);
                    formatter.Serialize(miStream, usuariosP);
                    miStream.Close();
                }

            }

            else
            {
                errorProvider5.SetError(comboBox1, "Debe ingresar una ocupacion");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRUT_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtRUT.Text, "[^0-9]"))
            {
                errorProvider2.SetError(txtRUT ,"Porfavor ingresar solo numeros");
                txtRUT.Text = txtRUT.Text.Remove(txtRUT.Text.Length - 1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFono_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFono.Text, "[^0-9]"))
            {
                errorProvider7.SetError(txtFono , "Porfavor ingresar solo numeros");
                txtFono.Text = txtFono.Text.Remove(txtFono.Text.Length - 1);
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            parent.Show();
            base.OnClosed(e);
        }
    }
}
