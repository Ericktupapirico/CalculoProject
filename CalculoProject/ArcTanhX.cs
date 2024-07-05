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
    public partial class ArcTanhX : Form
    {
        public ArcTanhX()
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



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

            if (valor <= -1 || valor >= 1)
            {
                MessageBox.Show("x debe estar en el intervalo -1 < x < 1 para la función arctanh.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ArcTanh arctanh = new ArcTanh(valor, terminos);

            MessageBox.Show("La respuesta es: " + arctanh.calcularSucesion(valor, terminos), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
