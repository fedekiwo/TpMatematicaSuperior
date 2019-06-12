using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        // -------OPERACIONES BASICAS----------

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

        private void textBox5_TextChanged(object sender, EventArgs e)
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
                    ComplexPolar num1 = validar(primerNumero);
                    ComplexPolar num2 = validar(segundoNumero);
                    ComplexPolar suma = num1 + num2;
                    textBox4.Text = textBox1.Text + " + " + textBox2.Text;
                    textBox3.Text = suma.ConvertToBinomicForm().GetNumber().ToString();
                    textBox5.Text = suma.GetNumber().ToString();

                }
                else
                    MessageBox.Show("No es un numero complejo ");
            }
        }

        private bool chequearQueEsComplejo(string numero)
        {
            if (verificarFormaBinomica(numero))
                return true;
            else if (verificarFormaPolar(numero))
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
            return numero.Substring(0, 1) == "[" && numero.Contains(';') && numero.Substring(numero.Length - 1, 1) == "]";
        }

        private ComplexPolar validar(string numero)
        {
            if (verificarFormaBinomica(numero))
            {
                numero = numero.Replace("(", "");
                numero = numero.Replace(")", "");
                String[] partesNumeroBinomico;
                partesNumeroBinomico = numero.Split(',');

                List<double> listaTransformada = new List<double>();

                listaTransformada = transformarStringADouble(partesNumeroBinomico);

                ComplexBinomic numeroBinomico = new ComplexBinomic(listaTransformada.ElementAt(0), listaTransformada.ElementAt(1));

                return numeroBinomico.ConvertToPolarForm();
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

                return numeroPolar;

            }
        }

        private List<double> transformarStringADouble(String[] lista)
        {
            List<double> listaNueva = new List<double>();

            foreach (String numero in lista)
            {
                listaNueva.Add(Convert.ToDouble(numero, new CultureInfo("en-US")));
            }

            return listaNueva;
        }

        private void button2_Click(object sender, EventArgs e)
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
                    ComplexPolar num1 = validar(primerNumero);
                    ComplexPolar num2 = validar(segundoNumero);
                    ComplexPolar resta = num1 - num2;
                    textBox4.Text = textBox1.Text + " - " + textBox2.Text;
                    textBox3.Text = resta.ConvertToBinomicForm().GetNumber().ToString();
                    textBox5.Text = resta.GetNumber().ToString();

                }
                else
                    MessageBox.Show("No es un numero complejo ");
            }


        }

        private void button3_Click(object sender, EventArgs e)
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
                    ComplexPolar num1 = validar(primerNumero);
                    ComplexPolar num2 = validar(segundoNumero);
                    ComplexPolar producto = num1 * num2;
                    textBox4.Text = textBox1.Text + " * " + textBox2.Text;
                    textBox3.Text = producto.ConvertToBinomicForm().GetNumber().ToString();
                    textBox5.Text = producto.GetNumber().ToString();

                }
                else
                    MessageBox.Show("No es un numero complejo ");
            }
        }


        private void button4_Click(object sender, EventArgs e)
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
                    ComplexPolar num1 = validar(primerNumero);
                    ComplexPolar num2 = validar(segundoNumero);
                    ComplexPolar division = num1 / num2;
                    textBox4.Text = textBox1.Text + " / " + textBox2.Text;
                    textBox3.Text = division.ConvertToBinomicForm().GetNumber().ToString();
                    textBox5.Text = division.GetNumber().ToString();

                }
                else
                    MessageBox.Show("No es un numero complejo ");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        // -----OPERACIONES AVANZADAS-------

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Falta completar los campos con numeros complejos");
            }
            else
            {
                string primerNumero = textBox6.Text;
                Int16 factor = new Int16();

                if (chequearQueEsComplejo(primerNumero) && Int16.TryParse(textBox7.Text, out factor))
                {
                    ComplexPolar num1 = validar(primerNumero);
                    ComplexPolar potencia = num1.Potencia(factor);

                    textBox8.Text = potencia.ConvertToBinomicForm().GetNumber().ToString();
                    textBox9.Text = potencia.GetNumber().ToString();

                }
                else
                    MessageBox.Show("No es un numero complejo ");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Falta completar los campos con numeros complejos");
            }
            else
            {
                string primerNumero = textBox6.Text;
                Int16 factor = new Int16();

                if (chequearQueEsComplejo(primerNumero) && Int16.TryParse(textBox7.Text, out factor))
                {
                    ComplexPolar num1 = validar(primerNumero);
                    List<ComplexPolar> raicesPrim = num1.Raiz(factor);

                    //ACA HABRIA QUE COMPLETAR LA TABLA CON LAS RAICES PRIMITIVAS
                }
                else
                    MessageBox.Show("No es un numero complejo ");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        //---------TRANSFORMACIONES--------

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                MessageBox.Show("Falta completar el campo con un numero complejo");
            }
            else
            {
                string primerNumero = textBox10.Text;

                if (chequearQueEsComplejo(primerNumero))
                {
                    ComplexPolar num1 = validar(primerNumero);

                    textBox11.Text = num1.ConvertToBinomicForm().GetNumber().ToString();
                    textBox12.Text = num1.GetNumber().ToString();

                }
                else
                    MessageBox.Show("No es un numero complejo ");
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
