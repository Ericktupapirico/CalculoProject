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
    public partial class SinhX : Form
    {
        public SinhX()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 8) // Backspace
            {
                e.Handled = false;
                return;
            }

            TextBox textBox = (TextBox)sender;
            string currentText = textBox.Text;

            // Permitir '-' solo si es el primer carácter y no hay otro '-' presente
            if (ch == '-' && textBox.SelectionStart == 0 && !currentText.Contains("-"))
            {
                e.Handled = false;
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

                // Permitir '.' solo si no hay otro decimal presente
                e.Handled = hasDecimal;

                if (!hasDecimal && currentText.Length == 0)
                {
                    // Si el texto actual está vacío, añadir "0."
                    textBox.Text = "0" + textBox.Text;
                    textBox.SelectionStart = textBox.Text.Length;
                }
                else if (currentText.EndsWith("."))
                {
                    // Si el texto termina con ".", añadir "0"
                    textBox.Text += "0";
                    textBox.SelectionStart = textBox.Text.Length;
                }
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

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double valor;
            int terminos;
            string text = textBox1.Text.Trim();
            if (text.EndsWith("."))
            {
                textBox1.Text += "0";

            }

            if (!double.TryParse(textBox1.Text, out valor))
            {
                MessageBox.Show("Por favor ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            terminos = (int)numericUpDown1.Value;


            Sinh sin = new Sinh(valor, terminos);

            MessageBox.Show("La respuesta es: " + sin.calcularSucesion(valor, terminos), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SinhX_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 8) // Backspace
            {
                e.Handled = false;
                return;
            }

            NumericUpDown numericUpDown = (NumericUpDown)sender;
            string currentText = numericUpDown.Text;

            if (ch == '-')
            {
                // Allow '-' only if it is the first character and no other '-' is present
                e.Handled = currentText.Length > 0 || numericUpDown.Text.Length != 0;
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
                
                // Allow '.' only if it is the first character or if there is no existing decimal
                e.Handled = hasDecimal || currentText.Length == 0;

                if (currentText.StartsWith("-") && !hasDecimal && currentText.Length == 1)
                {
                    // If the current text is "-", prepend "0."
                    numericUpDown.Text = "0.";
                    numericUpDown.Select(0, numericUpDown.Text.Length);
                    e.Handled = true;
                }
                else if (!hasDecimal && currentText.Length == 0)
                {
                    // If the current text is empty, prepend "0"
                    numericUpDown.Text = "0" + numericUpDown.Text;
                    numericUpDown.Select(2, 0);
                }
            }
        }
    }
}
