namespace Exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double ValorA = double.Parse(textBox1.Text);
                double ValorB = double.Parse(textBox2.Text);
                double sub = ValorA - ValorB;
                MessageBox.Show("A subtra��o dos valores � " + sub);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
            double ValorA = double.Parse(textBox1.Text);
            double ValorB = double.Parse(textBox2.Text);

            double div = ValorA / ValorB;
            MessageBox.Show("A divis�o dos valores � " + div);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double ValorA = double.Parse(textBox1.Text);
                double ValorB = double.Parse(textBox2.Text);

                double soma = ValorA + ValorB;
                MessageBox.Show("A soma dos valores � " + soma);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double ValorA = double.Parse(textBox1.Text);
                double ValorB = double.Parse(textBox2.Text);

                double mult = ValorA * ValorB;
                MessageBox.Show("A multiplica��o dos valores � " + mult);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
