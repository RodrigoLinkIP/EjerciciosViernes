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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            string p;
            double precio;
            bool esnumero;
            private void button1_Click(object sender, EventArgs e)
            {
                p = textBox1.Text;
                esnumero = double.TryParse(textBox1.Text, out precio);

                if (!esnumero)
                {
                    string nombre = "ERROR";
                    MessageBox.Show("Ingrese un caracter valido.", nombre);
                }
                if (precio > 0)
                {
                    if (esnumero)
                    {
                        double ganacia = precio * 0.30;
                        double total = precio + ganacia;
                        string nombre = "Aumento";
                        MessageBox.Show("El precio original es de: $" + precio + "\nLa ganancia de este producto sera de: $" + ganacia + "\nEl precio de venta sera de: $" + total, nombre);
                    }
                }
                else if (precio <= 0)
                {
                    string nombre = "ERROR";
                    MessageBox.Show("Ingrese un numero mayor a 0", nombre);
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }           
}
