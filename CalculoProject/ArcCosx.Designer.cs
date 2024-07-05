namespace CalculoProject
{
    partial class ArcCosx
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textButton1_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(100, 307);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 235);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 16;
            label3.Text = "Terminos";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(100, 258);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 15;
            numericUpDown1.KeyPress += numericUpDown1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 159);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 14;
            label2.Text = "Valor de X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(390, 87);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 13;
            label1.Text = "Calcular Serie para:  ArcCosX";
            // 
            // ArcCosx
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(659, 422);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ArcCosx";
            Text = "ArcCosX";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label1;
    }
}