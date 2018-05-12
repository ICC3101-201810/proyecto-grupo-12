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
using System.IO;

namespace WindowsFormsApp3.Froms
{
    public partial class Form3 : Form
    {
        List<Persona> usuariosP = new List<Persona>();

        public Form3()
        {
            InitializeComponent();
            usuariosP = (new Persona("", "", "", "", Persona.Ocupacion.Usuario, "", "", false)).GetListaUsuarios();
            XmlSerializer serializador = new XmlSerializer(usuariosP.GetType());
            FileStream archivo = new FileStream("Usuarios.xml", FileMode.Create, FileAccess.ReadWrite);
            serializador.Serialize(archivo, usuariosP);
            archivo.Close();

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
            p.LogOut(usuariosP);
            Form1 openform1 = new Form1();
            openform1.Show();
            Visible = false;
        }

        private void opcionesAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persona a = new Persona("", "", "", "", Persona.Ocupacion.Administrador, "", "", false);
            usuariosP = a.GetListaUsuarios();
            foreach (Persona per in usuariosP)
            {
                if (per.logedin == true)
                {
                    if (per.ocupacion == Persona.Ocupacion.Administrador)
                    {
                        opcionesAdministradorToolStripMenuItem.Visible = true;
                    }
                }
            }
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persona p = new Persona("", "", "", "", Persona.Ocupacion.Usuario, "", "", false);
            p.GetListaUsuarios();
            Froms.Form4 openform4 = new Froms.Form4();
            openform4.Show();
            Visible = false;
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reservarCanchaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 openform5 = new Form5();
            openform5.Show();
            Visible = false;
        }
    }
}
