namespace Coladera_de_Eratostenes
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
            this.btnfindPrimes = new System.Windows.Forms.Button();
            this.txtPrimes = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.btnMenorMil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfindPrimes
            // 
            this.btnfindPrimes.Location = new System.Drawing.Point(125, 18);
            this.btnfindPrimes.Name = "btnfindPrimes";
            this.btnfindPrimes.Size = new System.Drawing.Size(75, 23);
            this.btnfindPrimes.TabIndex = 0;
            this.btnfindPrimes.Text = "Find";
            this.btnfindPrimes.UseVisualStyleBackColor = true;
            this.btnfindPrimes.Click += new System.EventHandler(this.btnfindPrimes_Click);
            // 
            // txtPrimes
            // 
            this.txtPrimes.Location = new System.Drawing.Point(12, 68);
            this.txtPrimes.Multiline = true;
            this.txtPrimes.Name = "txtPrimes";
            this.txtPrimes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrimes.Size = new System.Drawing.Size(290, 281);
            this.txtPrimes.TabIndex = 1;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(206, 20);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 2;
            // 
            // btnMenorMil
            // 
            this.btnMenorMil.Location = new System.Drawing.Point(12, 12);
            this.btnMenorMil.Name = "btnMenorMil";
            this.btnMenorMil.Size = new System.Drawing.Size(95, 32);
            this.btnMenorMil.TabIndex = 3;
            this.btnMenorMil.Text = "Primes < 1000";
            this.btnMenorMil.UseVisualStyleBackColor = true;
            this.btnMenorMil.Click += new System.EventHandler(this.btnMenorMil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 361);
            this.Controls.Add(this.btnMenorMil);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtPrimes);
            this.Controls.Add(this.btnfindPrimes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfindPrimes;
        private System.Windows.Forms.TextBox txtPrimes;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Button btnMenorMil;
    }
}

