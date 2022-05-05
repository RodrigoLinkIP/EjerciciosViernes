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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p1;
            double persona1;
            bool esnumero1;
            string p2;
            double persona2;
            bool esnumero2;
            string p3;
            double persona3;
            bool esnumero3;
            double cien;

            esnumero1 = double.TryParse(textBox1.Text, out persona1);
            if (!esnumero1)
            {
                string nombre = "ERROR";
                MessageBox.Show("Escriba un caracter valido.");
            }
            if (esnumero1)
            {
                if(persona1 > 0)
                {
                    esnumero2 = double.TryParse(textBox2.Text, out persona2);
                    if (!esnumero2)
                    {
                        string nombre = "ERROR";
                        MessageBox.Show("Escriba un caracter valido.");
                    }
                    if (esnumero2)
                    {
                        if (persona2 > 0)
                        {
                            esnumero3 = double.TryParse(textBox3.Text, out persona3);
                            if (!esnumero3)
                            {
                                string nombre = "ERROR";
                                MessageBox.Show("Escriba un caracter valido.");
                            }
                            if (esnumero3)
                            {
                                if (persona3 > 0)
                                {
                                    cien = (persona1 + persona2 + persona3);
                                    string nombre = "Porcentajes de inversores.";
                                    double porcent1 = (persona1 * 100) / cien;
                                    double porcentaje1 = Math.Round(porcent1, 2);
                                    double porcent2 = (persona2 * 100) / cien;
                                    double porcentaje2 = Math.Round(porcent2, 2);
                                    double porcent3 = (persona3 * 100) / cien;
                                    double porcentaje3 = Math.Round(porcent3, 2);

                                    MessageBox.Show("El porcentaje que invirtio la Persona 1 fue de: %" + porcentaje1 + "\nEl porcentaje que invirtio la Persona 2 fue de: %" + porcentaje2 + "\nEl porcentaje que invirtio la Persona 3 fue de: %" + porcentaje3, nombre);
                                }
                            }
                            else if (persona3 <= 0)
                            {
                                string nombre = "ERROR";
                                MessageBox.Show("Escriba un numero mayor a 0", nombre);
                            }
                        }
                        else if (persona2 <= 0)
                        {
                            string nombre = "ERROR";
                            MessageBox.Show("Escriba un numero mayor a 0", nombre);
                        }
                    }
                }
                else if (persona1 <= 0)
                {
                    string nombre = "ERROR";
                    MessageBox.Show("Escriba un numero mayor a 0", nombre);
                }
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
