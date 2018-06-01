using System;

namespace WindowsFormsApp3.Froms
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.cbNumero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnASalas = new System.Windows.Forms.Button();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEspacio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "<----";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbNumero
            // 
            this.cbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumero.FormattingEnabled = true;
            this.cbNumero.Location = new System.Drawing.Point(261, 262);
            this.cbNumero.Name = "cbNumero";
            this.cbNumero.Size = new System.Drawing.Size(235, 21);
            this.cbNumero.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(79, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Número Espacio";
            // 
            // BtnASalas
            // 
            this.BtnASalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnASalas.Location = new System.Drawing.Point(482, 363);
            this.BtnASalas.Name = "BtnASalas";
            this.BtnASalas.Size = new System.Drawing.Size(139, 39);
            this.BtnASalas.TabIndex = 21;
            this.BtnASalas.Text = "Reservar";
            this.BtnASalas.UseVisualStyleBackColor = true;
            this.BtnASalas.Click += new System.EventHandler(this.BtnASalas_Click);
            // 
            // cbHorario
            // 
            this.cbHorario.AccessibleDescription = "cbBloque";
            this.cbHorario.AccessibleName = "cbBloque";
            this.cbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Items.AddRange(new object[] {
            "08:00-09:00",
            "09:00-10:00",
            "10:00-11:00",
            "11:00-12:00",
            "12:00-13:00",
            "13:00-14:00",
            "14:00-15:00",
            "15:00-16:00",
            "16:00-17:00",
            "17:00-18:00",
            "18:00-19:00",
            "19:00-20:00",
            ""});
            this.cbHorario.Location = new System.Drawing.Point(261, 212);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(236, 21);
            this.cbHorario.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AccessibleName = "Label4";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(79, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Horario";
            // 
            // cbDate
            // 
            this.cbDate.AccessibleDescription = "cbDate";
            this.cbDate.AccessibleName = "cbDate";
            this.cbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbDate.Location = new System.Drawing.Point(261, 169);
            this.cbDate.MinDate = new System.DateTime(2018, 5, 11, 0, 0, 0, 0);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(235, 20);
            this.cbDate.TabIndex = 18;
            this.cbDate.Value = new System.DateTime(2018, 5, 19, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(79, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Día";
            // 
            // cbEspacio
            // 
            this.cbEspacio.AccessibleDescription = "cbEspacio";
            this.cbEspacio.AccessibleName = "cbEspacio";
            this.cbEspacio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspacio.FormattingEnabled = true;
            this.cbEspacio.Items.AddRange(new object[] {
            "Estudio",
            "Cancha"});
            this.cbEspacio.Location = new System.Drawing.Point(261, 118);
            this.cbEspacio.Name = "cbEspacio";
            this.cbEspacio.Size = new System.Drawing.Size(141, 21);
            this.cbEspacio.TabIndex = 16;
            this.cbEspacio.SelectedIndexChanged += new System.EventHandler(this.cbEspacio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(79, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Espacio a Reservar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(203, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar Reserva";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnASalas);
            this.Controls.Add(this.cbHorario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEspacio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnASalas;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker cbDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEspacio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        public EventHandler button2_Click { get; private set; }
    }
}