using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDBApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=ADMINRG-5NS3932\TEW_SQLEXPRESS;Initial Catalog=demoDB;User ID=sa;Password=demo123";

            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand sqlCommand;
            SqlDataReader dataReader;
            String sql, Output = string.Empty;

            sql = "Select TutorialID,TutorialName from TutorialTable";

            sqlCommand = new SqlCommand(sql, cnn);

            dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "\n";
            }

            MessageBox.Show(Output);
            dataReader.Close();
            sqlCommand.Dispose();
            cnn.Close();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
