using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Producto producto;
        Registro registro = new Registro();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto = new Producto(txtName.Text, txtCodigo.Text, Convert.ToInt32(txtPrice.Text), txtDescripcion.Text, txtMarca.Text);
            registro.Agregar(producto);
            Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Clear();
            txtLista.Text = registro.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
                txtLista.Text = registro.Buscar(txtCodigo.Text).ToString();   
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            producto = new Producto(txtName.Text, txtCodigo.Text, Convert.ToInt32(txtPrice.Text), txtDescripcion.Text, txtMarca.Text);
            registro.Insertar(producto, Convert.ToInt32(txtSearch.Text));
            Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                registro.Eliminar(txtCodigo.Text);
        }

        public void Clear()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
        }
    }
}
