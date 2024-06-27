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
    public partial class Senx : Form
    {
        public Senx()
        {
            InitializeComponent();
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


            Sinx sinx = new Sinx(valor, terminos);

            MessageBox.Show("La respuesta es: " + sinx.calcularSucesion(valor, terminos), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void textBox1_Keypress(object sender, KeyPressEventArgs e)
        {
            // Obtener el carácter ingresado
            char ch = e.KeyChar;

            // Permitir el uso de la tecla de retroceso
            if (ch == 8)
            {
                e.Handled = false;
                return;
            }

            // Permitir solo números y un punto decimal
            if (!char.IsDigit(ch) && ch != '.' && ch != '-')
            {
                e.Handled = true;
                return;
            }

            // Permitir solo un punto decimal
            if (ch == '.' && textBox1.Text.Contains(".") && ch == '-' && textBox1.Text.Contains("-"))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
