using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Circulares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Estructura est = new Estructura();
        private void btnAgregarFinal_Click(object sender, EventArgs e)
        {
            Base bas;
            bas = new Base(txtNombreBase.Text, Convert.ToInt32(txtTiempo.Text));
            est.Agregar(bas);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtLista.Text = est.Buscar(txtSearch.Text).ToString();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            est.EliminarUltimo();
        }

        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            est.EliminarInicio();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            est.Eliminar(txtDelete.Text);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtLista.Text = est.listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Base bas;
            bas = new Base(txtNombreBase.Text, Convert.ToInt32(txtTiempo.Text));
            est.Insertar(bas, Convert.ToInt32(txtInsertar.Text));
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            txtLista.Text = est.Ruta(txtName.Text, Convert.ToDateTime(txtInicio.Text), Convert.ToDateTime(txtFin.Text));
        }
    }
}
