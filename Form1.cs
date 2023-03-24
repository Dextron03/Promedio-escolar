using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularNota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void respuesta_Click(object sender, EventArgs e)
        {
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pNota = double.Parse(textBox1.Text);
            double sNota = double.Parse(textBox2.Text);
            double tNota = double.Parse(textBox3.Text);
            double cNota = double.Parse(textBox4.Text);
            double promedio = (pNota + sNota + tNota + cNota) / 4;


            if (promedio >= 70)
            {
                respuesta.Text = ($"El estudiante fue promovido con un promedio de {promedio}");
                lblProRe.Text = ("Promovido");

            }
            if (promedio < 70)
            {
                respuesta.Text = ($"El estudiante a reprobado {promedio}");
                lblProRe.Text = ("Reprovado");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblProRe_Click(object sender, EventArgs e)
        {

        }
    }
}
