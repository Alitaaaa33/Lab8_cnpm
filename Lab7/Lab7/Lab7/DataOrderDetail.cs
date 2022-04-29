﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Lab7
{
    public partial class DataOrderDetail : Form
    {
        public DataOrderDetail()
        {
            InitializeComponent();
        }

        private void DataOrderDetail_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=JAGPC;Initial Catalog=Lab7;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT * FROM OrderDetail";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data");
            }
            conn.Close();
        }
    }
}
