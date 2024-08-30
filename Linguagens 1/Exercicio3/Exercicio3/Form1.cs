namespace Exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ValorA = int.Parse(textBox1.Text);
                int ValorB = int.Parse(textBox2.Text);

                if (ValorA % ValorB == 0)
                {
                    MessageBox.Show("O Valor A é multiplo de B " + ValorA / ValorB + " vezes");
                }
                else
                {
                    MessageBox.Show("O Valor A não é multiplo do Valor B");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
