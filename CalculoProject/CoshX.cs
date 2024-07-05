using CalculoProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoProject
{
    public partial class CoshX : Form
    {
        public CoshX()
        {
            InitializeComponent();
        }
        private void textButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 8)
            {
                e.Handled = false;
                return;
            }

            TextBox textBox = (TextBox)sender;
            string currentText = textBox.Text;

            if (ch == '-')
            {
                e.Handled = currentText.Length > 0 || textBox.SelectionStart != 0;
                return;
            }

            if (!char.IsDigit(ch) && ch != '.')
            {
                e.Handled = true;
                return;
            }

            if (ch == '.')
            {

                bool hasDecimal = currentText.Contains(".");

                e.Handled = hasDecimal || currentText.Length == 0;

                if (currentText.StartsWith("-") && !hasDecimal && currentText.Length == 1)
                {

                    textBox.Text = "-0.";
                    textBox.SelectionStart = textBox.Text.Length;
                    e.Handled = true;
                }
                else if (!hasDecimal && currentText.Length == 0)
                {

                    textBox.Text = "0" + textBox.Text;
                    textBox.SelectionStart = 2;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double valor;
            int terminos;

            if (!double.TryParse(textBox1.Text, out valor))
            {
                MessageBox.Show("Por favor ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            terminos = (int)numericUpDown1.Value;


            Cosh cos = new Cosh(valor, terminos);

            MessageBox.Show("La respuesta es: " + cos.calcularSucesion(valor, terminos), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
