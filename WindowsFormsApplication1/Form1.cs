using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hipotenusa_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            error.Text = "";
            try
            {
                double catetoA = Convert.ToDouble(input1.Text);
                double catetoB = Convert.ToDouble(input2.Text);

                double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

                resultado.Text = hipotenusa.ToString();
            }
            catch (Exception ex)
            {
                error.Text = "Error: " + ex;
                resultado.Text = "";
            }
        }

        private void vocales_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            error.Text = "";

            string palabra = input1.Text.Trim();

            if ((palabra.Contains("a") || palabra.Contains("á") || palabra.Contains("A")
                || palabra.Contains("Á"))
                && (palabra.Contains("e") || palabra.Contains("é") || palabra.Contains("E")
                || palabra.Contains("É"))
                && (palabra.Contains("i") || palabra.Contains("í") || palabra.Contains("I")
                || palabra.Contains("Í"))
                && (palabra.Contains("o") || palabra.Contains("ó") || palabra.Contains("O")
                || palabra.Contains("Ó"))
                && (palabra.Contains("u") || palabra.Contains("ú") || palabra.Contains("U")
                || palabra.Contains("Ú")))
            {
                resultado.Text = "Cumple";
            }
            else
            {
                resultado.Text = "No Cumple";
            }
        }

        private void inversor_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            error.Text = "";

            string nombre = input1.Text;
            string apellido = input2.Text;

            int counter;

            for (counter = nombre.Length; counter > 0; counter--)
            {
                resultado.Text += nombre[counter - 1];
            }

            resultado.Text += " ";

            for (counter = apellido.Length; counter > 0; counter--)
            {
                resultado.Text += apellido[counter - 1];
            }
        }

        private void regla3_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            error.Text = "";

            try
            {
                double A = Convert.ToDouble(input1.Text);
                double X = Convert.ToDouble(input2.Text);
                double B = Convert.ToDouble(input3.Text);

                double Y = (B * X / A);

                resultado.Text = Y.ToString();
            }
            catch (Exception ex)
            {
                error.Text = "Error: " + ex;
                resultado.Text = "";
            }
        }
    }
}
