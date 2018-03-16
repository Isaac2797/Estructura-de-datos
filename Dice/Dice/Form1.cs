using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sides;
        int[] doubledie;
        Dado d = new Dado();
        private void btnLanzar_Click(object sender, EventArgs e)
        {
       
            txtshow.Text += Convert.ToString(d.Lanzar()) + "\r\n"; 
        }

        private void btnLanzar100_Click(object sender, EventArgs e)
        {
            txtshow.Text = Lanzar100();

        }

        public string Lanzar100()
        {
            sides = new int[6];
            string cadena = "";
            for (int i = 0; i < 100; i++)
            {
                int dicenum = d.Lanzar();
                sides[dicenum - 1]++;
            }
            for (int i = 0; i < sides.Length; i++)
            {
                cadena += "Dado:" + (i+1) + " se repite " + sides[i] + "\r\n";
            }
            return cadena;
        }

        public string sumarlanzamiento()
        {
            doubledie = new int[11];

            string cadena = "";
         
            for (int i = 0; i < 100; i++)
            {
                int adddice = d.Lanzar() + d.Lanzar();
                doubledie[adddice - 2]++;
            }
            for (int i = 0; i < doubledie.Length; i++)
            {
                cadena += "Suma:" + (i + 2) + " se repite " + doubledie[i] + "\r\n";
            }
            return cadena;
        }

        private void btnDosdados_Click(object sender, EventArgs e)
        {
            txtshow.Text = Convert.ToString(sumarlanzamiento());
        }
    }
}
