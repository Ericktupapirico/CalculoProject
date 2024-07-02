namespace CalculoProject
{
    public partial class MainExcercises : Form
    {
        public MainExcercises()
        {
            InitializeComponent();
        }
        void AbrirForm(Form form)
        {
            while (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            Form formHijo = form;
            form.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel1.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirForm(form: new Form1());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirForm(form: new e_cosx());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirForm(form: new e_sinx());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm(form: new ArcCothx());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirForm(form: new ArcTanhX());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirForm(form: new CoshX());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirForm(form: new SinhX());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirForm(form: new Senx());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbrirForm(form: new Cosx());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirForm(form: new Ln());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AbrirForm(form: new ArcTanx());
        }


    }
}
