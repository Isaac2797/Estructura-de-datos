using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas_FIFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Procesador()
        {
            Random rt = new Random();
            Queue q = new Queue();
            Proceso proceso;
            int pro = 0, vac = 0, pen = 0, fin = 0, ins = 0;
            int cycles = 300;
            while (cycles > 0)
            {
                int chance = rt.Next(100);
                if(chance <= 35)
                {
                    proceso = new Proceso(rt.Next(4,15));
                    q.Put(proceso);
                    ins++;
                }

                if (q.Peek() == 0)
                {
                    vac++;
                    cycles--;
                }
                else
                {
                    pro++;
                    cycles--;
                    if(q.Peek() == pro)
                    {
                        q.Pop();
                        fin++;
                        pro = 0;
                    }
                }
            }
            pen = ins - fin;
            return "Procesos vacios: " + vac + " Procesos atendidos: " + fin + " Procesos Pendientes: " + pen + " Suma de ciclos: " + q.Count();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            txtShow.Text = Procesador();
        }
    }
}
