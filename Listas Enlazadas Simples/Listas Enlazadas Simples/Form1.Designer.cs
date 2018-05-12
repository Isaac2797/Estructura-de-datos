namespace Listas_Enlazadas_Simples
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarPrimero = new System.Windows.Forms.Button();
            this.btnEliminarUltimo = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.btnListarInverso = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre";
            // 
            // btnEliminarPrimero
            // 
            this.btnEliminarPrimero.Location = new System.Drawing.Point(207, 112);
            this.btnEliminarPrimero.Name = "btnEliminarPrimero";
            this.btnEliminarPrimero.Size = new System.Drawing.Size(117, 23);
            this.btnEliminarPrimero.TabIndex = 27;
            this.btnEliminarPrimero.Text = "Eliminar Primero";
            this.btnEliminarPrimero.UseVisualStyleBackColor = true;
            this.btnEliminarPrimero.Click += new System.EventHandler(this.btnEliminarPrimero_Click);
            // 
            // btnEliminarUltimo
            // 
            this.btnEliminarUltimo.Location = new System.Drawing.Point(207, 82);
            this.btnEliminarUltimo.Name = "btnEliminarUltimo";
            this.btnEliminarUltimo.Size = new System.Drawing.Size(117, 23);
            this.btnEliminarUltimo.TabIndex = 26;
            this.btnEliminarUltimo.Text = "Eliminar Ultimo";
            this.btnEliminarUltimo.UseVisualStyleBackColor = true;
            this.btnEliminarUltimo.Click += new System.EventHandler(this.btnEliminarUltimo_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(101, 147);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 25;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(101, 117);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 24;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(101, 86);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 23;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(101, 56);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 21;
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(207, 53);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(75, 23);
            this.btnInvertir.TabIndex = 20;
            this.btnInvertir.Text = "Invertir";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // btnListarInverso
            // 
            this.btnListarInverso.Location = new System.Drawing.Point(207, 141);
            this.btnListarInverso.Name = "btnListarInverso";
            this.btnListarInverso.Size = new System.Drawing.Size(117, 23);
            this.btnListarInverso.TabIndex = 19;
            this.btnListarInverso.Text = "Listar Inverso";
            this.btnListarInverso.UseVisualStyleBackColor = true;
            this.btnListarInverso.Click += new System.EventHandler(this.btnListarInverso_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(207, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(12, 186);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(410, 183);
            this.txtLista.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 424);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarPrimero);
            this.Controls.Add(this.btnEliminarUltimo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.btnListarInverso);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarPrimero;
        private System.Windows.Forms.Button btnEliminarUltimo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Button btnListarInverso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtLista;
    }
}

