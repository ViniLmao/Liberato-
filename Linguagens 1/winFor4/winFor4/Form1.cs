namespace winFor4
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int valorInicial = int.Parse(textBox1.Text) ;
                int valorFinal = int.Parse(textBox2.Text);
                int valor1a9 = int.Parse(textBox3.Text);

                listBox1.Items.Clear();
                if (valorInicial > valorFinal)
                {
                    MessageBox.Show("O valor inicial deve ser menor que o valor final");
                }
                else if (valor1a9 < 1 || valor1a9 > 9)
                {
                    MessageBox.Show("\"Valor\" invalido");
                }
                else
                {
                    for (int i = valorInicial; i <= valorFinal; i++)
                    {
                        listBox1.Items.Add(valor1a9 + "x" + i + "=" + valor1a9 * i);
                    }
                }
            } catch (FormatException)
            {
                MessageBox.Show("error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
