using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Lec10
{
    public partial class InsertData : Form
    {
        DataGridViewMain dgvm;

        public InsertData(DataGridViewMain dg)
        {
            InitializeComponent();
            this.dgvm = dg;
        }

        public void addSubmit_Click(object sender, EventArgs e)
        {
            //Fill Dataset
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ICT\C#\Lec10\Lec10.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Items";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Items");

            //Adding a New Row to Dataset
            DataRow row = set.Tables["Items"].NewRow();
            row["Id"] = addId.Text;
            row["Name"] = addName.Text;
            row["Price"] = addPrice.Text;
            row["Date"] = addDate.Text;
            set.Tables["Items"].Rows.Add(row);
            
            dgvm.dataGridView1.DataSource = set.Tables["Items"];

            //Updating Database Table
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(set.Tables["Items"]);

            MessageBox.Show("Dataset Saved to Database Successfully!");
        }
    }
}
