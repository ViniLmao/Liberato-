namespace winFor2
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, x = 3;
            for (i = 1; i <= 10; i++) 
            {
                if (i % 2 == 0) {
                    listBox1.Items.Add(x * i);
                }
            }
        }
    }
}
