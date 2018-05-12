using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_enlazadas_dobles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Estructura estruc = new Estructura();

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtLista.Text = estruc.listar();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Producto producto;
            producto = new Producto(txtName.Text, Convert.ToInt32(txtCodigo.Text), Convert.ToInt32(txtPrice.Text), txtDescripcion.Text, txtMarca.Text);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtLista.Text = estruc.buscar(Convert.ToInt32(txtSearch.Text)).ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estruc.eliminar(Convert.ToInt32(txtSearch.Text));
        }

        private void btnListarInverso_Click(object sender, EventArgs e)
        {
            txtLista.Text = estruc.listarInverso();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            estruc.eliminarUltimo();
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            estruc.eliminarPrimero();
        }
    }
}
