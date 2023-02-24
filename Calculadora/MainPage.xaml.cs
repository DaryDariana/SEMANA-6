using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Calculadora221115
{
    public partial class MainPage : ContentPage
    {
        private double num1;
        private double num2;
        private string operador;
        public MainPage()
        {
            InitializeComponent();
        }

        private void clickNumero(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = tmp.Text;
            }
            else
            {
                txtResultado.Text += tmp.Text;
            }

        }

        // Boton para limpiar pantalla
        private void clickLimpiar(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operador = null;
            txtResultado.Text = "0";
        }

        private void clickBorrar(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 0)
            {
                txtResultado.Text = txtResultado.Text.Substring
                (0, txtResultado.Text.Count() - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }


        private void clickSuma(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clickResta(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clickMultiplicar(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clickDividir(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clickPorcentaje(object sender, EventArgs e)
        {
            operador = "%";
            num1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clickIgual(object sender, EventArgs e)
        {
            if(txtResultado.Text == "")
            {
                txtResultado.Text = "0";
            }
            num2 = Double.Parse(txtResultado.Text);

            double operacionFinal = 0;

            switch (operador)
            {
                case "+":
                    operacionFinal = num1 + num2;
                    break;

                case "-":
                    operacionFinal = num1 - num2;
                    break;

                case "*":
                    operacionFinal = num1 * num2;
                    break;

                case "/":
                    operacionFinal = num1 / num2;
                    break;

                case "%":
                    operacionFinal = (num1/100) * num2;
                    break;
            }


            /*if (operador == "+")
                {
                    operacionFinal = num1 + num2;

                }
            else if(operador == "-")
                {
                    operacionFinal = num1 - num2;
                }
            else if (operador == "*")
                {
                    operacionFinal = num1 * num2;
                }
            else if(operador == "/")
               {
                    operacionFinal = num1 / num2;
               }*/


            txtResultado.Text = operacionFinal.ToString();

        }
    }
}
