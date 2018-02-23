using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Bits_y_Bytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);

            selectingBits(number);
            selectingDate(number);

        }

        int selectingBits(int number)
        {
            number >>= 1;
            int direction = number & 7; //Comparar valor con 00000111
            number >>= 3;

            int level = number & 3; //Comparar valor con 00000011
            number >>= 2;

            int Sensor2 = number & 1; //Comparar valor con 00000001
            number >>= 1;

            int Sensor1 = number & 1; //Comparar valor con 00000001

            return showInfo(direction, level, Sensor2, Sensor1);
        }

        int selectingDate(int number)
        {
            number >>= 8;

            int day = number & 31; //comparar valor con 00011111
            number >>= 5;
            if (day == 0)
            {
                MessageBox.Show("Dia cambiará a lunes");
                day = 1;
            }

            int month = number & 15; //comparar valor con 00001111
            if (month > 12)
            {
                MessageBox.Show("Mes cambiará a Diciembre");
                month = 12;
            }
            else if (month == 0)
            {
                MessageBox.Show("Mes cambiará a enero");
                month = 1;
            }
            number >>= 4;

            int year = number & 127; // comparar valor con 01111111
            year += 1900;

            DateTime date = new DateTime(year, month, day);

            string fulldate = String.Format("{0:dd/MM/yyyy}", date);

            

            txtDate.Text = fulldate;

            return 0;
            
        }

        long changeDate(DateTime dt)
        {
            int y = dt.Year-1900;
            int m = dt.Month;
            int d = dt.Day;
            int res = y;
            res <<= 4;
            res += m;
            res <<= 5;
            res += d;
           
            txtResult.Text = Convert.ToString(res);

            return 0;
        }

        int showInfo(int d, int l, int s2, int s1)
        {
            if(s1 == 1)
            {
                this.pb1.Image = Practica_Bits_y_Bytes.Properties.Resources.SEncendido;
            }
            else
            {
                this.pb1.Image = Practica_Bits_y_Bytes.Properties.Resources.SApagado;
            }

            if (s2 == 1)
            {
                this.pb2.Image = Practica_Bits_y_Bytes.Properties.Resources.SEncendido;
            }
            else
            {
                this.pb2.Image = Practica_Bits_y_Bytes.Properties.Resources.SApagado;
            }

            switch(l)
            {
                case 0:
                    this.pb3.Image = Practica_Bits_y_Bytes.Properties.Resources.Empty;
                    lblLevel.Text = "Vacio";
                    break;

                case 1:
                    this.pb3.Image = Practica_Bits_y_Bytes.Properties.Resources.Half_full;
                    lblLevel.Text = "Nivel medio";
                    break;

                case 2:
                    this.pb3.Image = Practica_Bits_y_Bytes.Properties.Resources.Full;
                    lblLevel.Text = "Lleno";
                    break;

                case 3:
                    this.pb3.Image = Practica_Bits_y_Bytes.Properties.Resources.Enproceso;
                    lblLevel.Text = "Proceso de llenado";
                    break;
                   
            }

            switch(d)
            {
                case 0: this.pb4.Image = Practica_Bits_y_Bytes.Properties.Resources.N; break;

                case 1: this.pb4.Image = Practica_Bits_y_Bytes.Properties.Resources.NE; break;

                case 2: this.pb4.Image = Practica_Bits_y_Bytes.Properties.Resources.E; break;

                case 3: this.pb4.Image = Practica_Bits_y_Bytes.Properties.Resources.SE; break;

                case 4: this.pb4.Image = Practica_Bits_y_Bytes.Properties.Resources.S; break;

                case 5: this.pb4.Image = Practica_Bits_y_Bytes.Properties.Resources.SO; break;

                case 6: this.pb4.Image = Practica_Bits_y_Bytes.Properties.Resources.O; break;

                case 7: this.pb4.Image = Practica_Bits_y_Bytes.Properties.Resources.NO; break;
            }

            return 0;
        }

        private void btnDate_Click(object sender, EventArgs e)
        {

            changeDate(dtp1.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
