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
    public partial class ArcCosx : Form
    {
        public ArcCosx()
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
                e.Handled = currentText.Length > 0 && textBox.SelectionStart != 0;
                return;
            }

            if (!char.IsDigit(ch) && ch != '.')
            {
                e.Handled = true;
                return;
            }


            if (ch == '.')
            {
                // Verificar si ya hay un punto decimal en el texto actual
                bool hasDecimal = currentText.Contains(".");

                // Permitir el punto solo si ya hay al menos un dígito
                e.Handled = hasDecimal || currentText.Length == 0;
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


            ArcCos sin = new ArcCos(valor, terminos);

            MessageBox.Show("La respuesta es: " + sin.calcularSucesion(valor, terminos), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
