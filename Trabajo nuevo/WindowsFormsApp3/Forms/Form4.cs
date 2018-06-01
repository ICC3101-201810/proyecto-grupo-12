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
    public partial class Form4 : Form
    {
        List<Persona> usuariosP;
        Persona p;

        public Form4()
        {
            InitializeComponent();
            BinaryFormatter formatter = new BinaryFormatter();
            Stream miStream = new FileStream("datosUsuarios.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            usuariosP = (List<Persona>)formatter.Deserialize(miStream);
            miStream.Close();
            foreach (Persona p in usuariosP)
            {
                dataGridView1.Rows.Add(p.nombre, p.mail, p.uId, p.ocupacion);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Froms.Form3 openform3 = new Froms.Form3();
            openform3.Show();
            Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
