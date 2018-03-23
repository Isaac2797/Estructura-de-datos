using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liebre_vs_Tortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Animales dug = new Tortuga();
        Animales snowball = new Liebre();

        private void btnStart_Click(object sender, EventArgs e)
        {
            carrera();
        }

        public void carrera()
        {
            dug.position = 0;
            snowball.position = 0;
            string cadena = "";

            while (dug.position < 80 && snowball.position < 80)
            {
                dug.position += dug.Correr();
                snowball.position += snowball.Correr();
                cadena += "La tortuga esta en la posicion: " + dug.position + "\r\n" + "La liebre esta en la posicion: " + snowball.position + "\r\n";
            }

            txtRace.Text = cadena;

            if (dug.position >= 80 && snowball.position < 80)
                txtWinner.Text = "Gano la tortuga ";
            else
                txtWinner.Text = "Gano la liebre ";

            if (dug.position >= 80 && snowball.position >= 80)
                txtWinner.Text = "Empate";
        }

        private void txtRabbit_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
