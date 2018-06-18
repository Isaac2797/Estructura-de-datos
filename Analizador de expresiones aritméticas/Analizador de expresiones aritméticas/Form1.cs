using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analizador_de_expresiones_aritméticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Arbol tree = new Arbol();
        Nodo value, Backup;

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Create();
            txtPost.Text = tree.Posty();
            Create();
            txtPreOrder.Text = tree.Presty(); ;
        }

        public void Create()
        {
            string numbers = txtEcuation.Text;
            for (int i = 0; i < numbers.Length; i++)
            {
                value = new Nodo(numbers[i].ToString());
                tree.Agregar(value);
            }
            tree.acomodar();

        }
    }
}
