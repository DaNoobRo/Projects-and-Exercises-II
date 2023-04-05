using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myDatabase
{
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection();
        BindingSource bindingSource1 = new BindingSource();
        BindingSource bindingSource2 = new BindingSource();
        DataTable dsUniv;
        DataTable dsFac;
        SqlDataAdapter daUniv, daFac;
        int Row_indexU, Row_indexF;


        public Form1()
        {
            InitializeComponent();

        }
        private void GetData()
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carvo\Documents\C#\Labs\Labs_II\myDatabase\Database1.mdf;Integrated Security=True";
            myCon.Open();

            dsUniv = new DataTable("dsUniv");
            dsFac = new DataTable("dsFac");
            daUniv = new SqlDataAdapter("SELECT NameUniv,City,Code FROM Universitati", myCon);
            daUniv.Fill(dsUniv);
            daFac = new SqlDataAdapter("SELECT * FROM Facultati ", myCon);
            daFac.Fill(dsFac);
            bindingSource1.DataSource = dsFac;
            bindingSource2.DataSource = dsUniv;
            var builderU = new SqlCommandBuilder(daUniv);
            var builderF = new SqlCommandBuilder(daFac);

            myCon.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
            dataGridView1.DataSource = bindingSource1;
            dataGridView2.DataSource = bindingSource2;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Row_indexF = e.RowIndex;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Row_indexU = e.RowIndex;
        }
        private void Save_Data(object sender, EventArgs e)
        {
            try
            {   
                daUniv.Update(dsUniv);
                daFac.Update(dsFac);
                GetData();
                MessageBox.Show("Update Done!");
            }
            catch (Exception exi) { 
                MessageBox.Show(exi.Message);
            }
        }

    }
}