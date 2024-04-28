namespace CalculadoraCapital
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
            this.inicialText = new System.Windows.Forms.TextBox();
            this.txttasa = new System.Windows.Forms.TextBox();
            this.txtTi = new System.Windows.Forms.TextBox();
            this.lblTasaInteres = new System.Windows.Forms.Label();
            this.lblCapitalInicial = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular Capital";
            // 
            // inicialText
            // 
            this.inicialText.Location = new System.Drawing.Point(294, 110);
            this.inicialText.Name = "inicialText";
            this.inicialText.Size = new System.Drawing.Size(166, 20);
            this.inicialText.TabIndex = 1;
            // 
            // txttasa
            // 
            this.txttasa.Location = new System.Drawing.Point(294, 174);
            this.txttasa.Name = "txttasa";
            this.txttasa.Size = new System.Drawing.Size(166, 20);
            this.txttasa.TabIndex = 2;
            // 
            // txtTi
            // 
            this.txtTi.Location = new System.Drawing.Point(294, 253);
            this.txtTi.Name = "txtTi";
            this.txtTi.Size = new System.Drawing.Size(176, 20);
            this.txtTi.TabIndex = 3;
            // 
            // lblTasaInteres
            // 
            this.lblTasaInteres.AutoSize = true;
            this.lblTasaInteres.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasaInteres.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTasaInteres.Location = new System.Drawing.Point(48, 174);
            this.lblTasaInteres.Name = "lblTasaInteres";
            this.lblTasaInteres.Size = new System.Drawing.Size(192, 29);
            this.lblTasaInteres.TabIndex = 4;
            this.lblTasaInteres.Text = "Tasa de interés";
            // 
            // lblCapitalInicial
            // 
            this.lblCapitalInicial.AutoSize = true;
            this.lblCapitalInicial.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitalInicial.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblCapitalInicial.Location = new System.Drawing.Point(48, 101);
            this.lblCapitalInicial.Name = "lblCapitalInicial";
            this.lblCapitalInicial.Size = new System.Drawing.Size(181, 29);
            this.lblCapitalInicial.TabIndex = 5;
            this.lblCapitalInicial.Text = "Capital Inicial";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTiempo.Location = new System.Drawing.Point(48, 253);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(216, 29);
            this.lblTiempo.TabIndex = 6;
            this.lblTiempo.Text = "Tiempo (en años)";
            // 
            // txtfinal
            // 
            this.txtfinal.Location = new System.Drawing.Point(283, 383);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(187, 20);
            this.txtfinal.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblResultado.Enabled = false;
            this.lblResultado.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblResultado.Location = new System.Drawing.Point(109, 374);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(131, 29);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCalcular.Location = new System.Drawing.Point(294, 308);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(175, 43);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblCapitalInicial);
            this.Controls.Add(this.lblTasaInteres);
            this.Controls.Add(this.txtTi);
            this.Controls.Add(this.txttasa);
            this.Controls.Add(this.inicialText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inicialText;
        private System.Windows.Forms.TextBox txttasa;
        private System.Windows.Forms.TextBox txtTi;
        private System.Windows.Forms.Label lblTasaInteres;
        private System.Windows.Forms.Label lblCapitalInicial;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

