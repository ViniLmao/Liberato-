namespace Baskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valorA = double.Parse(textBox3.Text);
                double valorB = double.Parse(textBox2.Text);
                double valorC = double.Parse(textBox1.Text);

                if (valorA == 0)
                {
                    MessageBox.Show("A não pode ser 0");
                }
                 else
                 {

                     double delta = Math.Pow(valorB, 2) - (4 * valorA * valorC);
                     double bhaskaraPositiva = (-valorB + Math.Sqrt(delta)) / (2 * valorA);
                     double bhaskaraNegativa = (-valorB - Math.Sqrt(delta)) / (2 * valorA);

                     MessageBox.Show("Os resultados da Bhaskara são " + bhaskaraPositiva.ToString() + " " + bhaskaraNegativa.ToString());
                 }
            }

             catch (FormatException)
            {
                MessageBox.Show("Necessita usar números");
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            } private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

