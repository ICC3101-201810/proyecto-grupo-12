namespace WindowsFormsApp3.Froms
{
    partial class Form5
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEspacio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.BtnASalas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNumero = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(207, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(83, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espacio a Reservar";
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
            this.cbEspacio.Location = new System.Drawing.Point(265, 117);
            this.cbEspacio.Name = "cbEspacio";
            this.cbEspacio.Size = new System.Drawing.Size(141, 21);
            this.cbEspacio.TabIndex = 2;
            this.cbEspacio.SelectedIndexChanged += new System.EventHandler(this.CbEspacio_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(83, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Día";
            // 
            // cbDate
            // 
            this.cbDate.AccessibleDescription = "cbDate";
            this.cbDate.AccessibleName = "cbDate";
            this.cbDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbDate.Location = new System.Drawing.Point(265, 168);
            this.cbDate.MinDate = new System.DateTime(2018, 5, 11, 0, 0, 0, 0);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(235, 20);
            this.cbDate.TabIndex = 4;
            this.cbDate.Value = new System.DateTime(2018, 5, 19, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AccessibleName = "Label4";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(83, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Horario";
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
            this.cbHorario.Location = new System.Drawing.Point(265, 211);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(236, 21);
            this.cbHorario.TabIndex = 6;
            // 
            // BtnASalas
            // 
            this.BtnASalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnASalas.Location = new System.Drawing.Point(486, 362);
            this.BtnASalas.Name = "BtnASalas";
            this.BtnASalas.Size = new System.Drawing.Size(139, 39);
            this.BtnASalas.TabIndex = 7;
            this.BtnASalas.Text = "Reservar";
            this.BtnASalas.UseVisualStyleBackColor = true;
            this.BtnASalas.Click += new System.EventHandler(this.BtnASalas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(83, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número Espacio";
            // 
            // cbNumero
            // 
            this.cbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumero.FormattingEnabled = true;
            this.cbNumero.Location = new System.Drawing.Point(265, 261);
            this.cbNumero.Name = "cbNumero";
            this.cbNumero.Size = new System.Drawing.Size(235, 21);
            this.cbNumero.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "<----";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AccessibleDescription = "Form5";
            this.AccessibleName = "Form5";
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
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEspacio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker cbDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.Button BtnASalas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNumero;
        private System.Windows.Forms.Button button2;
    }
}