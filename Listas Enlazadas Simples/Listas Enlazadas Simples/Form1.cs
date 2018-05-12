using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Enlazadas_Simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Estructura estruc = new Estructura();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto;
            producto = new Producto(txtName.Text, txtCodigo.Text, Convert.ToInt32(txtPrice.Text), txtDescripcion.Text, txtMarca.Text);
            estruc.agregar(producto);
            Clear();
        }

        public void Clear()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtCodigo.Clear();
            txtMarca.Clear();
            txtDescripcion.Clear();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            estruc.eliminarUltimo(); 
        }

        private void btnListarInverso_Click(object sender, EventArgs e)
        {
            txtLista.Text = estruc.listarInverso();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            estruc.Inverso();
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            estruc.eliminarPrimero();
        }
    }
}
