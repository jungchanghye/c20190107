﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GridTest
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = null;
        OleDbDataAdapter adapter = null;
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet("emp");

                //64비트
                
                string conStr = "Provider=OraOLEDB.Oracle;data source=topcredu;User ID=scott; Password = tiger";
                conn = new OleDbConnection(conStr);
                conn.Open();

                OleDbCommand command = new OleDbCommand("insert into emp (empno, ename) values ('9987', 'OJC_221')", conn);
                command.ExecuteNonQuery();

                adapter = new OleDbDataAdapter("select * from emp where ename = 'OJC_221'", conn);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "emp Table Loading Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
