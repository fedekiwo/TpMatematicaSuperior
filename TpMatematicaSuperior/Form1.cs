using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpMatematicaSuperior.Model.ComplexNumbers;

namespace TpMatematicaSuperior
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Falta completar los campos con numeros complejos");
            }
            else
            {
                string primerNumero = textBox1.Text;
                string segundoNumero = textBox2.Text;
                if (chequearQueEsComplejo(primerNumero) && chequearQueEsComplejo(segundoNumero))
                {
                    ComplexBinomic num1 = validar(primerNumero);
                    ComplexBinomic num2 = validar(segundoNumero);
                    ComplexBinomic suma = num1 + num2;
                    textBox4.Text = textBox1.Text + " + " + textBox2.Text;
                    textBox3.Text = suma.GetNumber().ToString();

                }
                else
                    MessageBox.Show("No es un numero complejo ");
            }
        }

        private bool chequearQueEsComplejo(string numero)
        {
            if ( verificarFormaBinomica(numero) )
                return true;
            else if ( verificarFormaPolar(numero) )
                return true;
            else
                return false;
        }

        private bool verificarFormaBinomica(string numero)
        {
            return numero.Substring(0, 1) == "(" && numero.Contains(',') && numero.Substring(numero.Length - 1, 1) == ")";
        }

        private bool verificarFormaPolar(string numero)
        {
            return numero.Substring(0, 1) == "[" && numero.Contains(',') && numero.Substring(numero.Length - 1, 1) == "]";
        }

        private ComplexBinomic validar(string numero)
        {
            if( verificarFormaBinomica(numero))
            {
                numero = numero.Replace("(", "");
                numero = numero.Replace(")", "");
                String[] partesNumeroBinomico;
                partesNumeroBinomico = numero.Split(',');

                List<double> listaTransformada = new List<double>();

                listaTransformada = transformarStringADouble(partesNumeroBinomico);

                return new ComplexBinomic( listaTransformada.ElementAt(0), listaTransformada.ElementAt(1) );
            }
            else
            {
                numero = numero.Replace("[", "");
                numero = numero.Replace("]", "");
                String[] partesNumeroPolar;
                partesNumeroPolar = numero.Split(';');

                List<double> listaTransformada = new List<double>();

                listaTransformada = transformarStringADouble(partesNumeroPolar);

                ComplexPolar numeroPolar = new ComplexPolar(listaTransformada.ElementAt(0), listaTransformada.ElementAt(1));

                return numeroPolar.ConvertToBinomicForm();

            }
        }

        private List<double> transformarStringADouble(String[] lista)
        {
            List<double> listaNueva = new List<double>();

            foreach(String numero in lista)
            {
                listaNueva.Add(Convert.ToDouble(numero));
            }

            return listaNueva;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox1.Text + " - " + textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox1.Text + " * " + textBox2.Text;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox1.Text + " / " + textBox2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

    }
}
