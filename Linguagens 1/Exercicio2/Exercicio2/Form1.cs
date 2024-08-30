namespace Exercicio2
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(textBox1.Text);
                if (valor % 2 == 0)
                {
                    MessageBox.Show("O N° é par");
                }
                else if (valor % 2 == 1)
                {
                    MessageBox.Show("O N° é impar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
