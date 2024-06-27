﻿using CalculoProject.Models;
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


            if (ch == 8)
            {
                e.Handled = false;
                return;
            }


            if (!char.IsDigit(ch) && ch != '.' && ch != '-')
            {
                e.Handled = true;
                return;
            }


            if (ch == '.' && textBox1.Text.Contains(".") && ch == '-' && textBox1.Text.Contains("-"))
            {
                e.Handled = true;
                return;
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


            Sinh sin = new Sinh(valor, terminos);

            MessageBox.Show("La respuesta es: " + sin.calcularSucesion(valor, terminos), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}