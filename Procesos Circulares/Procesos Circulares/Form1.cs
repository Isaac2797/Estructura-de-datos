using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesos_Circulares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Proceso proceso;
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = Procesador();
        }

        public string Procesador()
        {
            Random rt = new Random();
            Estructura est = new Estructura();
            int vac = 0, pen = 0, fin = 0, ins = 0;
            int cycles = 300;
            while (cycles > 0)
            {
                int chance = rt.Next(100);
                if (chance <= 35)
                {
                    proceso = new Proceso(rt.Next(4, 15));
                    est.Put(proceso);
                    ins++;
                }
                proceso = est.Next();
                if (est.Peek(proceso) == null)
                {
                    vac++;
                    cycles--;
                }
                else
                {
                    cycles--;
                    est.Peek(proceso).Process--;
                    if (est.Peek(proceso) == null)
                    {
                        est.Pop(proceso);
                        fin++;
                    }
                }
            }
            pen = ins - fin;
            return "Procesos vacios: " + vac + " Procesos atendidos: " + fin + " Procesos Pendientes: " + pen + " Suma de ciclos: " + est.Count();

        }
    }
}
