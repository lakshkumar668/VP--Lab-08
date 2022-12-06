using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            DataTable tableUsername = new DataTable();
            tableUsername.TableName = "username";

            DataColumn tableUsernameFirstColumn = new DataColumn();
            tableUsernameFirstColumn.ColumnName = "Id";
            tableUsernameFirstColumn.DataType = Type.GetType("System.Int32");


            DataColumn tableUsernameSecondColumn = new DataColumn();
            tableUsernameSecondColumn.ColumnName = "username";
            tableUsernameSecondColumn.DataType = Type.GetType("System.String");


            DataColumn tableUsernamethirdtColumn = new DataColumn();
            tableUsernamethirdtColumn.ColumnName = "password";
            tableUsernamethirdtColumn.DataType = Type.GetType("System.String");

            tableUsername.Columns.Add(tableUsernameFirstColumn);
            tableUsername.Columns.Add(tableUsernameSecondColumn);
            tableUsername.Columns.Add(tableUsernamethirdtColumn);

            DataRow dr1 = tableUsername.NewRow();
            dr1[0] = 1;
            dr1[1] = "new user";
            dr1[2] = "new password";

            tableUsername.Rows.Add(dr1);
            dataSet.Tables.Add(tableUsername);
            this.dataGridView1.DataSource = dataSet.Tables["username"];
        }
    }
}
