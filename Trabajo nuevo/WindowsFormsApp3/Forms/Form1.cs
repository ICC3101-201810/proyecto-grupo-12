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
    public partial class Form1 : Form
    {
        private ToolStripMenuItem mENUToolStripMenuItem;
        private TextBox txtLoginPass;
        private TextBox txtLoginName;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label4;
        private Button button1;
        private ToolStripMenuItem signInToolStripMenuItem1;
        private IContainer components;
        private MenuStrip menuStrip1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.signInToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // signInToolStripMenuItem1
            // 
            this.signInToolStripMenuItem1.Name = "signInToolStripMenuItem1";
            this.signInToolStripMenuItem1.Size = new System.Drawing.Size(59, 29);
            this.signInToolStripMenuItem1.Text = "Sign up";
            this.signInToolStripMenuItem1.Click += new System.EventHandler(this.signInToolStripMenuItem1_Click);
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.Location = new System.Drawing.Point(113, 196);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(422, 20);
            this.txtLoginPass.TabIndex = 10;
            this.txtLoginPass.UseSystemPasswordChar = true;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(113, 145);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(422, 20);
            this.txtLoginName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(21, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(21, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clave : ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(19, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Log in  : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(342, 274);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(27, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "aqui";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Aun no tiene su cuenta? para registrarse, click";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(725, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtLoginPass);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 openform = new Form2();
            openform.Show();
            Visible = false;
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 openform2 = new Form2();
            openform2.Show();
            Visible = false;
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Froms.Form3 openform3 = new Froms.Form3();
            openform3.Show();
            Visible = false;
        }

        private void listaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Persona LI = new Persona(txtLoginName.Text, "", "", "", Persona.Ocupacion.Administrador, "", txtLoginPass.Text, false);
            LI.LogIn(LI);
            if (LI.logedin == true)
            {
                Froms.Form3 openform3 = new Froms.Form3();
                openform3.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Su Nombre de Usuario o Contraseña estan incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 openform2 = new Form2();
            openform2.Show();
            Visible = false;
        }

        private void signInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 openform2 = new Form2();
            openform2.Show();
            Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
