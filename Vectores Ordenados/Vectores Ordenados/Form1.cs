using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores_Ordenados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Producto producto;
        Catalogo cat = new Catalogo();
        int limit = 0;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (limit < 15)
            {
                producto = new Producto(txtName.Text, Convert.ToInt32(txtCodigo.Text), Convert.ToInt32(txtPrice.Text), txtDescripcion.Text, txtMarca.Text);
                cat.Agregar(producto);
                limit++;
            }
            else
            {
                MessageBox.Show("No hay lugares disponibles");
            }
            Clear();
        }
   
        public void Clear()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtLista.Text = cat.Buscar(Convert.ToInt32(txtCodigo.Text)).ToString();
            Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cat.Eliminar(Convert.ToInt32(txtCodigo.Text));
            limit--;
            Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtLista.Text = cat.Listar();
        }
    }
}
