namespace Lab2_3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            Addition = new ToolStripMenuItem();
            Substraction = new ToolStripMenuItem();
            Multiplication = new ToolStripMenuItem();
            Division = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(567, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(567, 280);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(567, 342);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(182, 31);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(567, 190);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 3;
            label1.Text = "Number1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(567, 252);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Number2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(567, 314);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 5;
            label3.Text = "Result";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Addition, Substraction, Multiplication, Division });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "Operations";
            // 
            // Addition
            // 
            Addition.Name = "Addition";
            Addition.Size = new Size(62, 29);
            Addition.Text = "Add";
            Addition.Click += menuToolAdd_Click;
            // 
            // Substraction
            // 
            Substraction.Name = "Substraction";
            Substraction.Size = new Size(67, 29);
            Substraction.Text = "Subs";
            Substraction.Click += menuToolSubs_Click;
            // 
            // Multiplication
            // 
            Multiplication.Name = "Multiplication";
            Multiplication.Size = new Size(73, 29);
            Multiplication.Text = "Multy";
            Multiplication.Click += menuToolMulty_Click;
            // 
            // Division
            // 
            Division.Name = "Division";
            Division.Size = new Size(54, 29);
            Division.Text = "Div";
            Division.Click += menuToolDiv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Addition;
        private ToolStripMenuItem Substraction;
        private ToolStripMenuItem Multiplication;
        private ToolStripMenuItem Division;
    }
}