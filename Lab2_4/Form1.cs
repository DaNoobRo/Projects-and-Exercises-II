namespace Lab2_4
{
    public partial class Form1 : Form
    {
        Image[] deck = System.IO.Directory.GetFiles("C:\\Users\\carvo\\Documents\\C#\\Labs\\Labs_II\\Lab2_4\\Pictures\\")
                        .Select(file => System.Drawing.Image.FromFile(file))
                        .ToArray();

        private String getSelectedRadioButtonName_1()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is RadioButton && ((RadioButton)c).Checked == true)
                {
                    return c.Text;
                }
            }
            return "Not selected";
        }
        private String getSelectedRadioButtonName_2()
        {
            foreach (Control c in groupBox2.Controls)
            {
                if (c is RadioButton && ((RadioButton)c).Checked == true)
                {
                    return c.Text;
                }
            }
            return "Not selected";
        }
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Carnati");
            listBox1.Items.Add("Jumeri");
            listBox1.Items.Add("Sarmale");
            listBox1.Items.Add("Slanina");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FoodListShow(object sender, EventArgs e)
        {
            pictureBox1.Image = deck[listBox1.SelectedIndex];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Order_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked || radioButton2.Checked) && (radioButton3.Checked || radioButton4.Checked))
                MessageBox.Show("You ordered  : " + getSelectedRadioButtonName_1() + " " + getSelectedRadioButtonName_2());
            else MessageBox.Show("Please select from each group");
        }
    }
}