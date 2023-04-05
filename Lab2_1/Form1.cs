using System.IO;

namespace Lab2_1
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUser.Text;
            string password =txtBoxPass.Text;
            StreamReader sr= new StreamReader("C:\\Users\\carvo\\Documents\\C#\\Labs\\Labs_II\\Lab2_1\\credentials.txt");
            string[] lines = new string[2];
            lines[0] = sr.ReadLine();
            lines[1] = sr.ReadLine();
            if (username == lines[0] && password == lines[1])
            {
                Form2 secondForm = new Form2();
                secondForm.Show();
            }
            else { MessageBox.Show("username or password incorrect"); }
           
        }
    }
}