namespace winFor1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int valorInicial;
                int valorFinal;
                //for (x = 0; x <= 5; x++)
                valorInicial = int.Parse(textBox1.Text);
                valorFinal = int.Parse(textBox2.Text);

                for (int i = valorInicial; i <= valorFinal; i++)
                {
                    //listBox1.Items.Add(x.ToString());
                    listBox1.Items.Add(i.ToString());
                    //MessageBox.Show(x.ToString());
                }
            } catch (FormatException) {
                MessageBox.Show("Os valores precisam ser numeros!");
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
