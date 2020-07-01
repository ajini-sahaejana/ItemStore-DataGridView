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

namespace Lec10
{
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void getD_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ICT\C#\Lec10\Lec10.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Items";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet set = new DataSet();

            adapter.Fill(set, "Items");
            dataGridView1.DataSource = set.Tables["Items"];
        }

        private void insertD_Click(object sender, EventArgs e)
        {
            //Fill Dataset
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ICT\C#\Lec10\Lec10.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Items";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Items");

            //Adding a New Row to Dataset
            DataRow row = set.Tables["Items"].NewRow();
            row["Id"] = 1;
            row["Name"] = "4GB DDR3 RAM";
            row["Price"] = "50";
            row["Date"] = "26 May 2019";
            set.Tables["Items"].Rows.Add(row);

            dataGridView1.DataSource = set.Tables["Items"];

            //Updating Database Table
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(set.Tables["Items"]);

            MessageBox.Show("Dataset Saved to Database Successfully!");
        }

        private void updateD_Click(object sender, EventArgs e)
        {
            //Fill Dataset
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ICT\C#\Lec10\Lec10.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Items";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Items");

            set.Tables["Items"].Rows[0]["Name"] = "Graphics Card";

            dataGridView1.DataSource = set.Tables["Items"];

            //Updating Database Table
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(set.Tables["Items"]);

            MessageBox.Show("Database Updated Successfully!");
        }

        private void deleteD_Click(object sender, EventArgs e)
        {
            //Fill Dataset
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ICT\C#\Lec10\Lec10.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Items";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "Items");

            set.Tables["Items"].Rows[0].Delete();

            dataGridView1.DataSource = set.Tables["Items"];

            //Updating Database Table
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(set.Tables["Items"]);

            MessageBox.Show("Data Deleted Successfully!");
        }
    }
}
