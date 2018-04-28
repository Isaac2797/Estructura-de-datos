using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficos_por_Tortuga
{
    public partial class Form1 : Form
    {
        Campo camp = new Campo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            camp.Avanzar(Convert.ToInt32(txtMove.Text));
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            txtImprimir.Text = camp.Mostar();
        }

        private void btnGirarD_Click(object sender, EventArgs e)
        {
            camp.GirarDerecha();
        }

        private void btnGirarI_Click(object sender, EventArgs e)
        {
            camp.GirarIzquierda();
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            camp.PlumaArriba();
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            camp.PlumaAbajo();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }
    }
}
