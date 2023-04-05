namespace Tema1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RaceClass = new GroupBox();
            Class_CheckedListBox = new CheckedListBox();
            Race_CheckedListBox = new CheckedListBox();
            Gender_CheckedListBox = new CheckedListBox();
            Portrait = new PictureBox();
            raceAbility = new DataGridView();
            groupBox1 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            bCHA = new TextBox();
            bWIS = new TextBox();
            bINT = new TextBox();
            bCON = new TextBox();
            bDEX = new TextBox();
            bSTR = new TextBox();
            label6 = new Label();
            Modi_CHA = new TextBox();
            label5 = new Label();
            Modi_WIS = new TextBox();
            label4 = new Label();
            Modi_INT = new TextBox();
            label3 = new Label();
            Modi_CON = new TextBox();
            label2 = new Label();
            Modi_DEX = new TextBox();
            label1 = new Label();
            Modi_STR = new TextBox();
            pCHA = new NumericUpDown();
            pWIS = new NumericUpDown();
            pINT = new NumericUpDown();
            pCON = new NumericUpDown();
            pDEX = new NumericUpDown();
            pSTR = new NumericUpDown();
            groupBox3 = new GroupBox();
            totalPoint = new TextBox();
            groupBox2 = new GroupBox();
            comboBoxBG = new ComboBox();
            richTextBox1 = new RichTextBox();
            txtBox_HP = new TextBox();
            txtBox_AC = new TextBox();
            label12 = new Label();
            label13 = new Label();
            RaceClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Portrait).BeginInit();
            ((System.ComponentModel.ISupportInitialize)raceAbility).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pCHA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pWIS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pINT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pCON).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pDEX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pSTR).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // RaceClass
            // 
            RaceClass.BackColor = Color.DarkSlateBlue;
            RaceClass.Controls.Add(Class_CheckedListBox);
            RaceClass.Controls.Add(Race_CheckedListBox);
            RaceClass.Controls.Add(Gender_CheckedListBox);
            RaceClass.Controls.Add(Portrait);
            RaceClass.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RaceClass.ForeColor = Color.White;
            RaceClass.Location = new Point(587, 33);
            RaceClass.Name = "RaceClass";
            RaceClass.Size = new Size(581, 452);
            RaceClass.TabIndex = 0;
            RaceClass.TabStop = false;
            RaceClass.Text = "RaceClass";
            // 
            // Class_CheckedListBox
            // 
            Class_CheckedListBox.BackColor = Color.LightSeaGreen;
            Class_CheckedListBox.CheckOnClick = true;
            Class_CheckedListBox.ForeColor = Color.WhiteSmoke;
            Class_CheckedListBox.FormattingEnabled = true;
            Class_CheckedListBox.Location = new Point(21, 44);
            Class_CheckedListBox.Name = "Class_CheckedListBox";
            Class_CheckedListBox.Size = new Size(196, 139);
            Class_CheckedListBox.TabIndex = 4;
            Class_CheckedListBox.ItemCheck += Class_itemCheck;
            Class_CheckedListBox.SelectedIndexChanged += PortraitShow;
            // 
            // Race_CheckedListBox
            // 
            Race_CheckedListBox.BackColor = Color.Teal;
            Race_CheckedListBox.CheckOnClick = true;
            Race_CheckedListBox.ForeColor = Color.White;
            Race_CheckedListBox.FormattingEnabled = true;
            Race_CheckedListBox.Location = new Point(21, 299);
            Race_CheckedListBox.Name = "Race_CheckedListBox";
            Race_CheckedListBox.Size = new Size(196, 139);
            Race_CheckedListBox.TabIndex = 3;
            Race_CheckedListBox.ItemCheck += Race_itemChecked;
            Race_CheckedListBox.SelectedIndexChanged += PortraitShow;
            // 
            // Gender_CheckedListBox
            // 
            Gender_CheckedListBox.BackColor = Color.DarkSlateGray;
            Gender_CheckedListBox.CheckOnClick = true;
            Gender_CheckedListBox.ForeColor = Color.WhiteSmoke;
            Gender_CheckedListBox.FormattingEnabled = true;
            Gender_CheckedListBox.Items.AddRange(new object[] { "Female", "Male", "Other" });
            Gender_CheckedListBox.Location = new Point(21, 196);
            Gender_CheckedListBox.Name = "Gender_CheckedListBox";
            Gender_CheckedListBox.Size = new Size(196, 85);
            Gender_CheckedListBox.TabIndex = 2;
            Gender_CheckedListBox.ItemCheck += Gender_itemCheck;
            Gender_CheckedListBox.SelectedIndexChanged += PortraitShow;
            // 
            // Portrait
            // 
            Portrait.BackColor = Color.MidnightBlue;
            Portrait.Location = new Point(231, 44);
            Portrait.Name = "Portrait";
            Portrait.Size = new Size(330, 399);
            Portrait.TabIndex = 1;
            Portrait.TabStop = false;
            // 
            // raceAbility
            // 
            raceAbility.AllowUserToAddRows = false;
            raceAbility.AllowUserToDeleteRows = false;
            raceAbility.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            raceAbility.Location = new Point(15, 503);
            raceAbility.Name = "raceAbility";
            raceAbility.ReadOnly = true;
            raceAbility.RowHeadersWidth = 62;
            raceAbility.RowTemplate.Height = 33;
            raceAbility.Size = new Size(1143, 127);
            raceAbility.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DimGray;
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(bCHA);
            groupBox1.Controls.Add(bWIS);
            groupBox1.Controls.Add(bINT);
            groupBox1.Controls.Add(bCON);
            groupBox1.Controls.Add(bDEX);
            groupBox1.Controls.Add(bSTR);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Modi_CHA);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Modi_WIS);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Modi_INT);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Modi_CON);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Modi_DEX);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Modi_STR);
            groupBox1.Controls.Add(pCHA);
            groupBox1.Controls.Add(pWIS);
            groupBox1.Controls.Add(pINT);
            groupBox1.Controls.Add(pCON);
            groupBox1.Controls.Add(pDEX);
            groupBox1.Controls.Add(pSTR);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(9, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 450);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "PointBuy";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.IndianRed;
            label11.Location = new Point(65, 375);
            label11.Name = "label11";
            label11.Size = new Size(120, 23);
            label11.TabIndex = 30;
            label11.Text = "TotalPoint";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(479, 35);
            label10.Name = "label10";
            label10.Size = new Size(57, 23);
            label10.TabIndex = 28;
            label10.Text = "Modi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(371, 35);
            label9.Name = "label9";
            label9.Size = new Size(69, 23);
            label9.TabIndex = 27;
            label9.Text = "BONUS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(242, 35);
            label8.Name = "label8";
            label8.Size = new Size(42, 23);
            label8.TabIndex = 26;
            label8.Text = "PTS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 35);
            label7.Name = "label7";
            label7.Size = new Size(61, 23);
            label7.TabIndex = 25;
            label7.Text = "STATS";
            // 
            // bCHA
            // 
            bCHA.Location = new Point(371, 289);
            bCHA.Name = "bCHA";
            bCHA.ReadOnly = true;
            bCHA.Size = new Size(70, 30);
            bCHA.TabIndex = 24;
            // 
            // bWIS
            // 
            bWIS.Location = new Point(371, 243);
            bWIS.Name = "bWIS";
            bWIS.ReadOnly = true;
            bWIS.Size = new Size(70, 30);
            bWIS.TabIndex = 23;
            // 
            // bINT
            // 
            bINT.Location = new Point(370, 196);
            bINT.Name = "bINT";
            bINT.ReadOnly = true;
            bINT.Size = new Size(70, 30);
            bINT.TabIndex = 22;
            // 
            // bCON
            // 
            bCON.Location = new Point(370, 149);
            bCON.Name = "bCON";
            bCON.ReadOnly = true;
            bCON.Size = new Size(70, 30);
            bCON.TabIndex = 21;
            // 
            // bDEX
            // 
            bDEX.Location = new Point(370, 107);
            bDEX.Name = "bDEX";
            bDEX.ReadOnly = true;
            bDEX.Size = new Size(70, 30);
            bDEX.TabIndex = 20;
            // 
            // bSTR
            // 
            bSTR.Location = new Point(370, 64);
            bSTR.Name = "bSTR";
            bSTR.ReadOnly = true;
            bSTR.Size = new Size(70, 30);
            bSTR.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(16, 289);
            label6.Name = "label6";
            label6.Size = new Size(107, 23);
            label6.TabIndex = 17;
            label6.Text = "CHARISMA";
            // 
            // Modi_CHA
            // 
            Modi_CHA.Location = new Point(479, 289);
            Modi_CHA.Name = "Modi_CHA";
            Modi_CHA.ReadOnly = true;
            Modi_CHA.Size = new Size(70, 30);
            Modi_CHA.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(14, 243);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 15;
            label5.Text = "WISDOM";
            // 
            // Modi_WIS
            // 
            Modi_WIS.Location = new Point(479, 243);
            Modi_WIS.Name = "Modi_WIS";
            Modi_WIS.ReadOnly = true;
            Modi_WIS.Size = new Size(70, 30);
            Modi_WIS.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DimGray;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(14, 203);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 13;
            label4.Text = "INTELLIGENCE";
            // 
            // Modi_INT
            // 
            Modi_INT.Location = new Point(479, 196);
            Modi_INT.Name = "Modi_INT";
            Modi_INT.ReadOnly = true;
            Modi_INT.Size = new Size(70, 30);
            Modi_INT.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(14, 152);
            label3.Name = "label3";
            label3.Size = new Size(150, 23);
            label3.TabIndex = 11;
            label3.Text = "CONSTITUTION";
            // 
            // Modi_CON
            // 
            Modi_CON.Location = new Point(479, 149);
            Modi_CON.Name = "Modi_CON";
            Modi_CON.ReadOnly = true;
            Modi_CON.Size = new Size(70, 30);
            Modi_CON.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(14, 109);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 9;
            label2.Text = "DEXTERITY";
            // 
            // Modi_DEX
            // 
            Modi_DEX.Location = new Point(479, 106);
            Modi_DEX.Name = "Modi_DEX";
            Modi_DEX.ReadOnly = true;
            Modi_DEX.Size = new Size(70, 30);
            Modi_DEX.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(14, 67);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 7;
            label1.Text = "STRENGTH";
            // 
            // Modi_STR
            // 
            Modi_STR.Location = new Point(479, 61);
            Modi_STR.Name = "Modi_STR";
            Modi_STR.ReadOnly = true;
            Modi_STR.Size = new Size(70, 30);
            Modi_STR.TabIndex = 6;
            // 
            // pCHA
            // 
            pCHA.Location = new Point(245, 286);
            pCHA.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            pCHA.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            pCHA.Name = "pCHA";
            pCHA.Size = new Size(71, 30);
            pCHA.TabIndex = 5;
            pCHA.Value = new decimal(new int[] { 8, 0, 0, 0 });
            pCHA.ValueChanged += calcCHAmodi;
            // 
            // pWIS
            // 
            pWIS.Location = new Point(245, 241);
            pWIS.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            pWIS.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            pWIS.Name = "pWIS";
            pWIS.Size = new Size(71, 30);
            pWIS.TabIndex = 4;
            pWIS.Value = new decimal(new int[] { 8, 0, 0, 0 });
            pWIS.ValueChanged += calcWISmodi;
            // 
            // pINT
            // 
            pINT.Location = new Point(245, 196);
            pINT.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            pINT.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            pINT.Name = "pINT";
            pINT.Size = new Size(71, 30);
            pINT.TabIndex = 3;
            pINT.Value = new decimal(new int[] { 8, 0, 0, 0 });
            pINT.ValueChanged += calcINTmodi;
            // 
            // pCON
            // 
            pCON.Location = new Point(245, 150);
            pCON.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            pCON.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            pCON.Name = "pCON";
            pCON.Size = new Size(71, 30);
            pCON.TabIndex = 2;
            pCON.Value = new decimal(new int[] { 8, 0, 0, 0 });
            pCON.ValueChanged += calcCONmodi;
            // 
            // pDEX
            // 
            pDEX.Location = new Point(245, 107);
            pDEX.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            pDEX.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            pDEX.Name = "pDEX";
            pDEX.Size = new Size(71, 30);
            pDEX.TabIndex = 1;
            pDEX.Value = new decimal(new int[] { 8, 0, 0, 0 });
            pDEX.ValueChanged += calcDEXmodi;
            // 
            // pSTR
            // 
            pSTR.Location = new Point(245, 65);
            pSTR.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            pSTR.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            pSTR.Name = "pSTR";
            pSTR.Size = new Size(71, 30);
            pSTR.TabIndex = 0;
            pSTR.Value = new decimal(new int[] { 8, 0, 0, 0 });
            pSTR.ValueChanged += calcSTRmodi;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.PowderBlue;
            groupBox3.Controls.Add(totalPoint);
            groupBox3.Location = new Point(36, 337);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(513, 93);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            // 
            // totalPoint
            // 
            totalPoint.Location = new Point(244, 35);
            totalPoint.Name = "totalPoint";
            totalPoint.ReadOnly = true;
            totalPoint.Size = new Size(229, 30);
            totalPoint.TabIndex = 29;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SteelBlue;
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtBox_AC);
            groupBox2.Controls.Add(txtBox_HP);
            groupBox2.Controls.Add(comboBoxBG);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(1174, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(561, 599);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Background";
            // 
            // comboBoxBG
            // 
            comboBoxBG.FormattingEnabled = true;
            comboBoxBG.Items.AddRange(new object[] { "Acolyte", "Criminal", "Folk_hero", "Noble", "Sage", "Soldier" });
            comboBoxBG.Location = new Point(26, 472);
            comboBoxBG.Name = "comboBoxBG";
            comboBoxBG.Size = new Size(240, 31);
            comboBoxBG.TabIndex = 0;
            comboBoxBG.SelectedValueChanged += ShowBG;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(16, 46);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(530, 399);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // txtBox_HP
            // 
            txtBox_HP.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_HP.Location = new Point(284, 530);
            txtBox_HP.Name = "txtBox_HP";
            txtBox_HP.ReadOnly = true;
            txtBox_HP.Size = new Size(123, 47);
            txtBox_HP.TabIndex = 1;
            // 
            // txtBox_AC
            // 
            txtBox_AC.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_AC.Location = new Point(429, 530);
            txtBox_AC.Name = "txtBox_AC";
            txtBox_AC.ReadOnly = true;
            txtBox_AC.Size = new Size(117, 47);
            txtBox_AC.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(294, 476);
            label12.Name = "label12";
            label12.Size = new Size(104, 23);
            label12.TabIndex = 3;
            label12.Text = "HitPoints";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(423, 476);
            label13.Name = "label13";
            label13.Size = new Size(123, 23);
            label13.TabIndex = 4;
            label13.Text = "ArmorClass";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1793, 702);
            Controls.Add(groupBox1);
            Controls.Add(raceAbility);
            Controls.Add(RaceClass);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            RaceClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Portrait).EndInit();
            ((System.ComponentModel.ISupportInitialize)raceAbility).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pCHA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pWIS).EndInit();
            ((System.ComponentModel.ISupportInitialize)pINT).EndInit();
            ((System.ComponentModel.ISupportInitialize)pCON).EndInit();
            ((System.ComponentModel.ISupportInitialize)pDEX).EndInit();
            ((System.ComponentModel.ISupportInitialize)pSTR).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RaceClass;
        private PictureBox Portrait;
        private CheckedListBox Gender_CheckedListBox;
        private DataGridView raceAbility;
        private GroupBox groupBox1;
        private TextBox Modi_STR;
        private NumericUpDown pCHA;
        private NumericUpDown pWIS;
        private NumericUpDown pINT;
        private NumericUpDown pCON;
        private NumericUpDown pDEX;
        private NumericUpDown pSTR;
        private Label label1;
        private Label label6;
        private TextBox Modi_CHA;
        private Label label5;
        private TextBox Modi_WIS;
        private Label label4;
        private TextBox Modi_INT;
        private Label label3;
        private TextBox Modi_CON;
        private Label label2;
        private TextBox Modi_DEX;
        private CheckedListBox Race_CheckedListBox;
        private CheckedListBox Class_CheckedListBox;
        private GroupBox groupBox2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox bCHA;
        private TextBox bWIS;
        private TextBox bINT;
        private TextBox bCON;
        private TextBox bDEX;
        private TextBox bSTR;
        private Label label11;
        private TextBox totalPoint;
        private GroupBox groupBox3;
        private RichTextBox richTextBox1;
        private ComboBox comboBoxBG;
        private Label label13;
        private Label label12;
        private TextBox txtBox_AC;
        private TextBox txtBox_HP;
    }
}