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
        private ToolStripMenuItem signInToolStripMenuItem;
        private ToolStripMenuItem logInToolStripMenuItem;
        private ToolStripMenuItem listaUsuariosToolStripMenuItem;
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
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInToolStripMenuItem,
            this.logInToolStripMenuItem,
            this.listaUsuariosToolStripMenuItem});
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.signInToolStripMenuItem.Text = "Sign in";
            this.signInToolStripMenuItem.Click += new System.EventHandler(this.signInToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.logInToolStripMenuItem.Text = "Log in";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // listaUsuariosToolStripMenuItem
            // 
            this.listaUsuariosToolStripMenuItem.Name = "listaUsuariosToolStripMenuItem";
            this.listaUsuariosToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.listaUsuariosToolStripMenuItem.Text = "Lista Usuarios";
            this.listaUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listaUsuariosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(725, 387);
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
    }
}
