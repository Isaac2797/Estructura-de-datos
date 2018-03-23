using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coladera_de_Eratostenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Eratosthenes primes;
        private void btnfindPrimes_Click(object sender, EventArgs e)
        {
            primes = new Eratosthenes(Convert.ToInt32(txtLimit.Text));
            primes.fill();
            primes.findPrimes();
            txtPrimes.Text = primes.getPrimes();
        }

        private void btnMenorMil_Click(object sender, EventArgs e)
        {
            primes = new Eratosthenes(1000);
            primes.fill();
            primes.findPrimes();
            txtPrimes.Text = primes.getPrimes();
        }
    }
}
