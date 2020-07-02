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
    public partial class DataGridViewMain : Form
    {
        public DataGridViewMain()
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

        public void insertD_Click(object sender, EventArgs e)
        {
            InsertData i1 = new InsertData();
            i1.Show();
        }

        private void updateD_Click(object sender, EventArgs e)
        {
            UpdateData u1 = new UpdateData();
            u1.Show();
        }

        private void deleteD_Click(object sender, EventArgs e)
        {
            DeleteData d1 = new DeleteData();
            d1.Show();
        }
    }
}
