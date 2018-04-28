namespace Graficos_por_Tortuga
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
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtImprimir = new System.Windows.Forms.TextBox();
            this.btnGirarD = new System.Windows.Forms.Button();
            this.btnGirarI = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.txtMove = new System.Windows.Forms.TextBox();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(126, 10);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(75, 23);
            this.btnAvanzar.TabIndex = 0;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(12, 10);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtImprimir
            // 
            this.txtImprimir.Location = new System.Drawing.Point(12, 131);
            this.txtImprimir.Multiline = true;
            this.txtImprimir.Name = "txtImprimir";
            this.txtImprimir.Size = new System.Drawing.Size(299, 298);
            this.txtImprimir.TabIndex = 2;
            // 
            // btnGirarD
            // 
            this.btnGirarD.Location = new System.Drawing.Point(207, 82);
            this.btnGirarD.Name = "btnGirarD";
            this.btnGirarD.Size = new System.Drawing.Size(83, 23);
            this.btnGirarD.TabIndex = 3;
            this.btnGirarD.Text = "Girar Derecha";
            this.btnGirarD.UseVisualStyleBackColor = true;
            this.btnGirarD.Click += new System.EventHandler(this.btnGirarD_Click);
            // 
            // btnGirarI
            // 
            this.btnGirarI.Location = new System.Drawing.Point(116, 82);
            this.btnGirarI.Name = "btnGirarI";
            this.btnGirarI.Size = new System.Drawing.Size(85, 23);
            this.btnGirarI.TabIndex = 4;
            this.btnGirarI.Text = "Girar Izquierda";
            this.btnGirarI.UseVisualStyleBackColor = true;
            this.btnGirarI.Click += new System.EventHandler(this.btnGirarI_Click);
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(12, 43);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(75, 23);
            this.btnArriba.TabIndex = 5;
            this.btnArriba.Text = "Pluma Arriba";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(12, 82);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(75, 23);
            this.btnAbajo.TabIndex = 6;
            this.btnAbajo.Text = "Pluma Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // txtMove
            // 
            this.txtMove.Location = new System.Drawing.Point(116, 43);
            this.txtMove.Name = "txtMove";
            this.txtMove.Size = new System.Drawing.Size(100, 20);
            this.txtMove.TabIndex = 7;
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(236, 40);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(75, 23);
            this.btnFin.TabIndex = 8;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 441);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.txtMove);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnArriba);
            this.Controls.Add(this.btnGirarI);
            this.Controls.Add(this.btnGirarD);
            this.Controls.Add(this.txtImprimir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAvanzar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtImprimir;
        private System.Windows.Forms.Button btnGirarD;
        private System.Windows.Forms.Button btnGirarI;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.TextBox txtMove;
        private System.Windows.Forms.Button btnFin;
    }
}

