namespace Lab2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuToolAdd_Click(object sender, EventArgs e)
        {
            int suma = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            textBox3.Text = suma.ToString();
        }

        private void menuToolSubs_Click(object sender, EventArgs e)
        {
            int diff = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            textBox3.Text = diff.ToString();
        }

        private void menuToolMulty_Click(object sender, EventArgs e)
        {
            int mult = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            textBox3.Text = mult.ToString();
        }

        private void menuToolDiv_Click(object sender, EventArgs e)
        {
            double divi = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
            textBox3.Text = divi.ToString();
        }
    }
}