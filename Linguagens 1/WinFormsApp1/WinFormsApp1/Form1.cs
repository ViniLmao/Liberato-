namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           try{
                int x;
                x = int.Parse(textBox1.Text);
                if (x > 0) {
                    MessageBox.Show("Número Positivo");
                }
                else if (x < 0) {
                    MessageBox.Show("Número Negativo");
                }
                else 
                {
                    MessageBox.Show("Número é Zero");
                }
           }
                catch(Exception ex) {
                MessageBox.Show(ex.Message);
                } 
           }
        }
    }
