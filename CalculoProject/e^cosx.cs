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
    public partial class e_cosx : Form
    {
        public e_cosx()
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


            ExCos cosx = new ExCos(valor, terminos);

            MessageBox.Show("La respuesta es: " + cosx.calcularSucesion(valor, terminos), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void e_cosx_Load(object sender, EventArgs e)
        {

        }
    }
}