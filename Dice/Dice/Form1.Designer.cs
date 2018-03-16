namespace Dice
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
            this.btnLanzar = new System.Windows.Forms.Button();
            this.btnLanzar100 = new System.Windows.Forms.Button();
            this.txtshow = new System.Windows.Forms.TextBox();
            this.btnDosdados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(13, 13);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(75, 23);
            this.btnLanzar.TabIndex = 0;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // btnLanzar100
            // 
            this.btnLanzar100.Location = new System.Drawing.Point(94, 13);
            this.btnLanzar100.Name = "btnLanzar100";
            this.btnLanzar100.Size = new System.Drawing.Size(75, 23);
            this.btnLanzar100.TabIndex = 1;
            this.btnLanzar100.Text = " Lanzar 100";
            this.btnLanzar100.UseVisualStyleBackColor = true;
            this.btnLanzar100.Click += new System.EventHandler(this.btnLanzar100_Click);
            // 
            // txtshow
            // 
            this.txtshow.Location = new System.Drawing.Point(13, 42);
            this.txtshow.Multiline = true;
            this.txtshow.Name = "txtshow";
            this.txtshow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtshow.Size = new System.Drawing.Size(140, 96);
            this.txtshow.TabIndex = 2;
            // 
            // btnDosdados
            // 
            this.btnDosdados.Location = new System.Drawing.Point(175, 13);
            this.btnDosdados.Name = "btnDosdados";
            this.btnDosdados.Size = new System.Drawing.Size(75, 23);
            this.btnDosdados.TabIndex = 3;
            this.btnDosdados.Text = "3";
            this.btnDosdados.UseVisualStyleBackColor = true;
            this.btnDosdados.Click += new System.EventHandler(this.btnDosdados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDosdados);
            this.Controls.Add(this.txtshow);
            this.Controls.Add(this.btnLanzar100);
            this.Controls.Add(this.btnLanzar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.Button btnLanzar100;
        private System.Windows.Forms.TextBox txtshow;
        private System.Windows.Forms.Button btnDosdados;
    }
}

