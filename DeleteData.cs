﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lec10
{    public partial class DeleteData : Form
    {
        DataGridViewMain dgvm;
        public DeleteData(DataGridViewMain dg)
        {
            InitializeComponent();
            this.dgvm = dg;
        }

        private void deleteSubmit_Click(object sender, EventArgs e)
        {
            //Fill Dataset
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ICT\C#\Lec10\Lec10.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Items";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Items");

            //int rowindex = dgvm.dataGridView1.CurrentCell.RowIndex;
            //dgvm.dataGridView1.Rows.RemoveAt(rowindex);

            int row = (int.Parse(deleteId.Text)) - 1;
            set.Tables["Items"].Rows[row].Delete();

            dgvm.dataGridView1.DataSource = set.Tables["Items"];

            //Updating Database Table
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(set.Tables["Items"]);

            MessageBox.Show("Data Deleted Successfully!");
            this.Hide();
        }
    }
}
