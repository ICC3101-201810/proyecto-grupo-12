using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApp3.Froms
{
    public partial class Form3 : Form
    {
        List<Persona> usuariosP = new List<Persona>();
        Persona p;

        public Form3()
        {
            InitializeComponent();
            BinaryFormatter formatter = new BinaryFormatter();
            Stream miStream = new FileStream("datosUsuarios.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            usuariosP = (List<Persona>)formatter.Deserialize(miStream);
            miStream.Close();
            foreach (Persona p in usuariosP)
            {
                if(p.logedin == true)
                {
                    if (p.ocupacion == Persona.Ocupacion.Administrador)
                    {
                        opcionesAdministradorToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        opcionesAdministradorToolStripMenuItem.Visible = false;
                    }
                }
            }
        }

        private void listaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persona p = new Persona("", "", "", "", Persona.Ocupacion.Usuario, "", "", true);
            Controller.LogOut(usuariosP);
            Form1 openform1 = new Form1();
            openform1.Show();
            Visible = false;
        }

        private void opcionesAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Froms.Form4 openform4 = new Froms.Form4();
            openform4.Show();
            Visible = false;
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reservarCanchaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 openform6 = new Form6();
            openform6.Show();
            Visible = false;
        }
    }
}
