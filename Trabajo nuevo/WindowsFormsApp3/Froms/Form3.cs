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
        Form1 parent;

        public Form3(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
            if (Controller.ReturnCurrent().ocupacion == Persona.Ocupacion.Administrador)
            {
                opcionesAdministradorToolStripMenuItem.Visible = true;
            }
            else
            {
                opcionesAdministradorToolStripMenuItem.Visible = false;
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
            Controller.LogOut();
            this.Close();
        }

        private void opcionesAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Froms.Form4 openform4 = new Froms.Form4(this);
            openform4.Show();
            Visible = false;
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reservarCanchaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 openform6 = new Form6(this);
            openform6.Show();
            this.Hide();
        }

        protected override void OnClosed(EventArgs e)
        {
            parent.Show();
            base.OnClosed(e);
        }
    }
}
