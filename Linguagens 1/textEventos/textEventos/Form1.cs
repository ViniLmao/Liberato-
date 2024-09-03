namespace textEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Selecionado " + listBox1.Text);


            try
            {
                const double PI = (double)Math.PI;
                double ValorA = double.Parse(textBox1.Text);
                double ValorB = double.Parse(textBox2.Text);

                if (listBox1.Text == "quadrado")
                {
                    MessageBox.Show("O resultado da área é " + (Math.Pow(ValorA, 2)).ToString());
                }
                if (listBox1.Text == "circulo")
                {
                    MessageBox.Show("O resultado da área é " + (PI * Math.Pow(ValorA, 2)).ToString());
                }
                if (listBox1.Text == "retangulo")
                {
                    MessageBox.Show("O resultado da área é " + (ValorA * ValorB).ToString());
                }
                if (listBox1.Text == "triangulo")
                {
                    MessageBox.Show("O resultado da área é " + ((ValorA * ValorB) / 2).ToString());
                }
                if (listBox1.Text == "raiz quadrada")
                {
                    MessageBox.Show("O resultado da raiz quadrada é " + Math.Sqrt(ValorA));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("Entrada de texto");
            //clicar na caixa com o mouse 
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            //MessageBox.Show("Mouse saiu do text box");
            //tirar o mouse de cima
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "quadrado")
            {
                label1.Text = "lado";
                textBox2.Text = "0";
                label2.Hide();
                textBox2.Hide();

            }
            if (listBox1.Text == "circulo")
            {
                label1.Text = "raio";
                textBox2.Text = "0";
                label2.Show();
                label2.Text = "PI = 3,1415";
                textBox2.Hide();
            }
            if (listBox1.Text == "retangulo")
            {
                label1.Text = "base";
                label2.Show();
                label2.Text = string.Empty;
                label2.Text = "altura";
                textBox2.Show();
            }
            if (listBox1.Text == "triangulo")
            {
                label1.Text = "base";
                label2.Text = string.Empty;
                label2.Show();
                label2.Text = "altura";
                textBox2.Show();

            }
            if (listBox1.Text == "raiz quadrada")
            {
                label1.Text = "Valor";
                textBox2.Text = "0";
                label2.Show();
                label2.Hide();
                textBox2.Hide();
            }
        }
    }
}
