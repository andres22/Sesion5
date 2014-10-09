namespace AppRadioButton2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNuemro1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rdSuma = new System.Windows.Forms.RadioButton();
            this.rdresta = new System.Windows.Forms.RadioButton();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuemro1
            // 
            this.lblNuemro1.AutoSize = true;
            this.lblNuemro1.Location = new System.Drawing.Point(78, 49);
            this.lblNuemro1.Name = "lblNuemro1";
            this.lblNuemro1.Size = new System.Drawing.Size(56, 13);
            this.lblNuemro1.TabIndex = 0;
            this.lblNuemro1.Text = "Número 1:";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(78, 82);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(56, 13);
            this.lblNumero2.TabIndex = 1;
            this.lblNumero2.Text = "Número 2:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(78, 113);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado:";
            // 
            // rdSuma
            // 
            this.rdSuma.AutoSize = true;
            this.rdSuma.Location = new System.Drawing.Point(277, 45);
            this.rdSuma.Name = "rdSuma";
            this.rdSuma.Size = new System.Drawing.Size(52, 17);
            this.rdSuma.TabIndex = 3;
            this.rdSuma.TabStop = true;
            this.rdSuma.Text = "Suma";
            this.rdSuma.UseVisualStyleBackColor = true;
            // 
            // rdresta
            // 
            this.rdresta.AutoSize = true;
            this.rdresta.Location = new System.Drawing.Point(277, 85);
            this.rdresta.Name = "rdresta";
            this.rdresta.Size = new System.Drawing.Size(53, 17);
            this.rdresta.TabIndex = 4;
            this.rdresta.TabStop = true;
            this.rdresta.Text = "Resta";
            this.rdresta.UseVisualStyleBackColor = true;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(150, 42);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 5;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(150, 82);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 6;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(150, 113);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 7;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(277, 109);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 432);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.rdresta);
            this.Controls.Add(this.rdSuma);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNuemro1);
            this.Name = "Form1";
            this.Text = "Programa Suma y Resta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuemro1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton rdSuma;
        private System.Windows.Forms.RadioButton rdresta;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnMostrar;
    }
}

