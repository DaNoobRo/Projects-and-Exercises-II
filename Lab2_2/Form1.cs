using System.IO;

namespace Lab2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("C:\\Users\\carvo\\Documents\\C#\\Labs\\Labs_II\\Lab2_2\\ItemList.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
                listBox1.Items.Add(line);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (listBox1 != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}