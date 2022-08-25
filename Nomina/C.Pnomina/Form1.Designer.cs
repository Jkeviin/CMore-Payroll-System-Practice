namespace C.Pnomina
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDtrabajados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtRbasico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRauxilio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRDevengado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RbMensual = new System.Windows.Forms.RadioButton();
            this.RbQuincenal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE SU NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(218, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(218, 137);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(264, 20);
            this.txtCedula.TabIndex = 2;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(218, 209);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(264, 20);
            this.txtSueldo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESE SUELDO";
            // 
            // txtDtrabajados
            // 
            this.txtDtrabajados.Location = new System.Drawing.Point(218, 172);
            this.txtDtrabajados.Name = "txtDtrabajados";
            this.txtDtrabajados.Size = new System.Drawing.Size(264, 20);
            this.txtDtrabajados.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "INGRESE LOS DIAS TRABAJADOS ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "INGRESE SU CEDULA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Oswald", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 49);
            this.label5.TabIndex = 8;
            this.label5.Text = "CALCULO DE NOMINA";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(227, 301);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(200, 58);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtRbasico
            // 
            this.txtRbasico.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRbasico.Font = new System.Drawing.Font("Oswald", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRbasico.ForeColor = System.Drawing.Color.Black;
            this.txtRbasico.Location = new System.Drawing.Point(201, 23);
            this.txtRbasico.Name = "txtRbasico";
            this.txtRbasico.Size = new System.Drawing.Size(197, 27);
            this.txtRbasico.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "SALARIO BASICO";
            // 
            // txtRauxilio
            // 
            this.txtRauxilio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRauxilio.Font = new System.Drawing.Font("Oswald", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRauxilio.ForeColor = System.Drawing.Color.Black;
            this.txtRauxilio.Location = new System.Drawing.Point(201, 58);
            this.txtRauxilio.Name = "txtRauxilio";
            this.txtRauxilio.Size = new System.Drawing.Size(197, 27);
            this.txtRauxilio.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "AUXILIO DE TRANSPORTE";
            // 
            // txtRDevengado
            // 
            this.txtRDevengado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRDevengado.Font = new System.Drawing.Font("Oswald", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRDevengado.ForeColor = System.Drawing.Color.Black;
            this.txtRDevengado.Location = new System.Drawing.Point(201, 95);
            this.txtRDevengado.Name = "txtRDevengado";
            this.txtRDevengado.Size = new System.Drawing.Size(197, 27);
            this.txtRDevengado.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "TOTAL DEVENGADO";
            // 
            // RbMensual
            // 
            this.RbMensual.AutoSize = true;
            this.RbMensual.Checked = true;
            this.RbMensual.Location = new System.Drawing.Point(17, 19);
            this.RbMensual.Name = "RbMensual";
            this.RbMensual.Size = new System.Drawing.Size(77, 17);
            this.RbMensual.TabIndex = 15;
            this.RbMensual.TabStop = true;
            this.RbMensual.Text = "MENSUAL";
            this.RbMensual.UseVisualStyleBackColor = true;
            // 
            // RbQuincenal
            // 
            this.RbQuincenal.AutoSize = true;
            this.RbQuincenal.Location = new System.Drawing.Point(114, 19);
            this.RbQuincenal.Name = "RbQuincenal";
            this.RbQuincenal.Size = new System.Drawing.Size(87, 17);
            this.RbQuincenal.TabIndex = 16;
            this.RbQuincenal.Text = "QUINCENAL";
            this.RbQuincenal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbQuincenal);
            this.groupBox1.Controls.Add(this.RbMensual);
            this.groupBox1.Location = new System.Drawing.Point(218, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 50);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "SELECCIONE TIPO DE PAGO";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtRDevengado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtRbasico);
            this.groupBox2.Controls.Add(this.txtRauxilio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(540, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 151);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDtrabajados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "APLICACION NOMINA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre; 
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDtrabajados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtRbasico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRauxilio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRDevengado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton RbMensual;
        private System.Windows.Forms.RadioButton RbQuincenal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

