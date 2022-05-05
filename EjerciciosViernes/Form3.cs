using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosViernes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox1.Visible = true;
            button3.Visible = true;
            label4.Visible = false;
            button4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string m;
            double medida;
            bool esnumero;
            m = textBox1.Text;
            esnumero = double.TryParse(m, out medida);
            if (!esnumero)
            {
                string nombre = "ERROR";
                MessageBox.Show("Caracteres no validos.", nombre);
            }
            if (medida > 0)
            {
                if (esnumero)
                {
                    double conversion;
                    conversion = medida / 1.609;
                    string nombre = "Conversion";
                    MessageBox.Show("La medida en Km es de: " + conversion + "millas", nombre);
                }
            }
            else if (medida <= 0)
            {
                string nombre = "ERROR";
                MessageBox.Show("Ingrese un numero mayor a 0", nombre);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            textBox1.Visible = true;
            button4.Visible = true;
            label3.Visible = false;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string m;
            double medida;
            bool esnumero;
            m = textBox1.Text;
            esnumero = double.TryParse(m, out medida);
            if (!esnumero)
            {
                string nombre = "ERROR";
                MessageBox.Show("Caracteres no validos.", nombre);
            }
            if (medida > 0)
            {
                if (esnumero)
                {
                    double conversion;
                    conversion = medida * 1.609;
                    string nombre = "Conversion";
                    MessageBox.Show("La medida en Millas es de: " + conversion + " km", nombre);
                }
            }
            else if (medida <= 0)
            {
                string nombre = "ERROR";
                MessageBox.Show("Ingrese un numero mayor a 0", nombre);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
