namespace for;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int x;
        for (x = 0; x <= 5; x++)
        {
            listBox1.Items.Add(x.ToString());
        }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
