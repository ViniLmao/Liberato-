namespace winFor3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            for (x = 0; x < 100; x++)
            {
                if (x % 3 == 0)
                {
                    listBox1.Items.Add("Multiplos de 3 " + x);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int y;
            for (y = 0; y < 100; y++)
            {
                if (y % 5 == 0)
                {
                    listBox1.Items.Add("Multiplos de 5 " + y);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
