using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Tema1
{
    public partial class Form1 : Form
    {

        // Global Variables
        SqlConnection myCon = new SqlConnection();
        SqlDataAdapter daRaces, daClasses;
        BindingSource bindingSource1 = new BindingSource();
        DataSet dsRaces, dsClasses;
        DataTable dtRaces;


        // For running change the path from .GetFiles("") with what full path was
        // copied for folder Picture_Ref
        Image[] deck = System.IO.Directory.GetFiles("C:\\Users\\carvo\\Documents\\C#\\Labs\\Labs_II\\Tema1\\Picture_Ref\\")
                        .Select(file => System.Drawing.Image.FromFile(file))
                        .ToArray();

        // stuff used for some index formulas
        int nrClasses = 4;
        int nrRaces = 4;
        int pointsSpent = 0;

        //Lists for racial bonuses taken from database
        List<int> Strength = new List<int>();
        List<int> Dexterity = new List<int>();
        List<int> Constitution = new List<int>();
        List<int> Intelligence = new List<int>();
        List<int> Wisdom = new List<int>();
        List<int> Charisma = new List<int>();

        // Lists for AC and Hit Points
        List<int> ArmorClass = new List<int>();
        List<int> HitPoints = new List<int>();

        // HP and AC inherited from class
        int inhHP;
        int inhAC;

        public Form1()
        {
            InitializeComponent();
        }
        private void GetData()
        {

            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carvo\Documents\C#\Labs\Labs_II\Tema1\Database1.mdf;Integrated Security=True";
            myCon.Open();

            dsRaces = new DataSet();
            dsClasses = new DataSet();
            dtRaces = new DataTable("dtRaces");

            daRaces = new SqlDataAdapter("SELECT * FROM Races", myCon);
            daRaces.Fill(dsRaces, "Races");
            daRaces.Fill(dtRaces);
            daClasses = new SqlDataAdapter("SELECT * FROM Classes", myCon);
            daClasses.Fill(dsClasses, "Classes");

            bindingSource1.DataSource = dtRaces;
            raceAbility.DataSource = bindingSource1;


            foreach (DataRow dr in dsRaces.Tables["Races"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                Race_CheckedListBox.Items.Add(name);
                Strength.Add((int)(dr.ItemArray.GetValue(2)));
                Dexterity.Add((int)(dr.ItemArray.GetValue(3)));
                Constitution.Add((int)(dr.ItemArray.GetValue(4)));
                Intelligence.Add((int)(dr.ItemArray.GetValue(5)));
                Wisdom.Add((int)(dr.ItemArray.GetValue(6)));
                Charisma.Add((int)(dr.ItemArray.GetValue(7)));
            }
            foreach (DataRow dr2 in dsClasses.Tables["Classes"].Rows)
            {
                String name2 = dr2.ItemArray.GetValue(1).ToString();
                Class_CheckedListBox.Items.Add(name2);
                HitPoints.Add((int)(dr2.ItemArray.GetValue(2)));
                ArmorClass.Add((int)(dr2.ItemArray.GetValue(3)));

            }


            myCon.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void resetPoinBuy() {
            pINT.Value = Convert.ToDecimal(8);
            pCHA.Value = Convert.ToDecimal(8);
            pCON.Value = Convert.ToDecimal(8);
            pDEX.Value = Convert.ToDecimal(8);
            pWIS.Value = Convert.ToDecimal(8);
            pSTR.Value = Convert.ToDecimal(8);
        }
        private void totalPointSpent() {
            int sum = Convert.ToInt32(pCON.Value)+Convert.ToInt32(pCHA.Value)+Convert.ToInt32(pDEX.Value)+Convert.ToInt32(pINT.Value)+Convert.ToInt32(pWIS.Value)+Convert.ToInt32(pSTR.Value);
            totalPoint.Text = (sum-48).ToString()+"/27";
        }
        private void PortraitShow(object sender, EventArgs e)
        {
            if (Class_CheckedListBox.SelectedIndex >= 0 && Race_CheckedListBox.SelectedIndex >= 0 && Gender_CheckedListBox.SelectedIndex >= 0)
            {
                int i = (Class_CheckedListBox.SelectedIndex) * (3 * nrRaces) + (Race_CheckedListBox.SelectedIndex) * 3 + (Gender_CheckedListBox.SelectedIndex);
                Portrait.Image = deck[i];
                Portrait.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Class_itemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < Class_CheckedListBox.Items.Count; ++ix)
                if (ix != e.Index) Class_CheckedListBox.SetItemChecked(ix, false);
                inhHP = (HitPoints[e.Index]);
                inhAC = (ArmorClass[e.Index]);
                txtBox_HP.Text = inhHP.ToString();
                txtBox_AC.Text = inhAC.ToString();
                resetPoinBuy();
        }

        private void Gender_itemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < Gender_CheckedListBox.Items.Count; ++ix)
                if (ix != e.Index) Gender_CheckedListBox.SetItemChecked(ix, false);
        }

        private void Race_itemChecked(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < Race_CheckedListBox.Items.Count; ++ix)
                if (ix != e.Index) Race_CheckedListBox.SetItemChecked(ix, false);
            bSTR.Text = Strength[e.Index].ToString();
            bDEX.Text = Dexterity[e.Index].ToString();
            bCON.Text = Constitution[e.Index].ToString();
            bINT.Text = Intelligence[e.Index].ToString();
            bWIS.Text = Wisdom[e.Index].ToString();
            bCHA.Text = Charisma[e.Index].ToString();
            resetPoinBuy();
            Modi_STR.Text = (calcModi(Convert.ToInt32(pSTR.Value), int.Parse(bSTR.Text))).ToString();
            Modi_CHA.Text = (calcModi(Convert.ToInt32(pCHA.Value), int.Parse(bCHA.Text))).ToString();
            Modi_CON.Text = (calcModi(Convert.ToInt32(pCON.Value), int.Parse(bCON.Text))).ToString();
            Modi_INT.Text = (calcModi(Convert.ToInt32(pINT.Value), int.Parse(bINT.Text))).ToString();
            Modi_WIS.Text = (calcModi(Convert.ToInt32(pWIS.Value), int.Parse(bWIS.Text))).ToString();
            Modi_DEX.Text = (calcModi(Convert.ToInt32(pDEX.Value), int.Parse(bDEX.Text))).ToString();
        }

        private void ShowBG(object sender, EventArgs e)
        {
            string selectedText = this.comboBoxBG.GetItemText(this.comboBoxBG.SelectedItem);
            string filename = "C:\\Users\\carvo\\Documents\\C#\\Labs\\Labs_II\\Tema1\\Background_files\\" + selectedText + ".rtf";
            richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);
        }

        private int calcModi(int Base, int Bonus)
        {

            int result = (Base + Bonus - 10) / 2;
            return result;
        }

        private void calcSTRmodi(object sender, EventArgs e)
        {
            Modi_STR.Text = (calcModi(Convert.ToInt32(pSTR.Value), int.Parse(bSTR.Text))).ToString();
            totalPointSpent();
        }

        private void calcDEXmodi(object sender, EventArgs e)
        {
            Modi_DEX.Text = (calcModi(Convert.ToInt32(pDEX.Value), int.Parse(bDEX.Text))).ToString();
            try {
                if (inhAC <= 14)
                    txtBox_AC.Text = (inhAC + Convert.ToInt32(Modi_DEX.Text)).ToString();
                else txtBox_AC.Text = (inhAC).ToString();
            } catch { }
            totalPointSpent();
        }

        private void calcCONmodi(object sender, EventArgs e)
        {
            Modi_CON.Text = (calcModi(Convert.ToInt32(pCON.Value), int.Parse(bCON.Text))).ToString();
            try
            {
                txtBox_HP.Text = (inhHP + Convert.ToInt32(Modi_CON.Text)).ToString();
            }
            catch { }
            totalPointSpent();
        }

        private void calcINTmodi(object sender, EventArgs e)
        {
            Modi_INT.Text = (calcModi(Convert.ToInt32(pINT.Value), int.Parse(bINT.Text))).ToString();
            totalPointSpent() ;
        }

        private void calcWISmodi(object sender, EventArgs e)
        {
            Modi_WIS.Text = (calcModi(Convert.ToInt32(pWIS.Value), int.Parse(bWIS.Text))).ToString();
            totalPointSpent();
        }

        private void calcCHAmodi(object sender, EventArgs e)
        {
            Modi_CHA.Text = (calcModi(Convert.ToInt32(pCHA.Value), int.Parse(bCHA.Text))).ToString();
            totalPointSpent();        
        }
    }
}