using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendence.Dal;
using static Attendence.Dal.DBContext;

namespace Attendence
{
    public partial class ClockForm : Form
    {
        public ClockForm(string WorkerID)
        {
            InitializeComponent();
            labelIdentetyNumber.Text = WorkerID;
           
            if (NoEntry(WorkerID))
            {
                labelEnteryDate.Text = "";
                labelExitDate.Text = "";
            }
            else if (IsExitNull(WorkerID))
            {
                labelEnteryDate.Text = GetLastEntry(WorkerID);
                labelExitDate.Text = GetLastExit(WorkerID);
            }
            else
            {
                labelEnteryDate.Text = GetLastEntry(WorkerID);
                labelExitDate.Text = GetLastExit(WorkerID);
            }
        }

        private void linkLabelCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
 
            this.Close();

        }
        private static bool IsExitNull(string id)
        {
            DBContext _dbContext = new DBContext();
            var res = _dbContext.MakeQuery($"select * from EmployeeAttendance where ExitTime is null and EmployeeCode = (select ID from Employees where EmployeeNat = '{id}')");
            return ((res.Rows.Count == 0));
        }

        private static bool NoEntry(string id)
        {
            DBContext _dbContext = new DBContext();
            var res = _dbContext.MakeQuery($"select EntryTime from EmployeeAttendance where EmployeeCode = (select ID from Employees where EmployeeNat = '{id}')");
            return ((res.Rows.Count == 0));
        }

        private static string GetLastEntry(string id)
        {

            string query = "select max(EntryTime) " +
                "from EmployeeAttendance " +
                "where EmployeeCode = (" +
                "                       select ID from Employees where EmployeeNat = @id" +
                ");";

            using SqlConnection connection = new(_connectionString);
            connection.Open();
            SqlCommand cmd = new(query, connection);
            cmd.Parameters.AddWithValue("@id", id);


            var res = cmd.ExecuteScalar().ToString();
            return res;
            
         
        }

        private static string GetLastExit(string id)
        {

            string query = "select max(ExitTime) " +
                "from EmployeeAttendance " +
                "where EmployeeCode = (" +
                "                       select ID from Employees where EmployeeNat = @id" +
                ");";

            using SqlConnection connection = new(_connectionString);
            connection.Open();
            SqlCommand cmd = new(query, connection);
            cmd.Parameters.AddWithValue("@id", id);


            var res = cmd.ExecuteScalar().ToString();
            return res;


        }

        private static void InsertEnter(DateTime date, string id)
            
        {
            

            string query = "insert into EmployeeAttendance " +
                "(EmployeeCode, EntryTime) " +
                "values" +
                "(" +
                    "(select ID from Employees where EmployeeNat = @id), " +
                    "@expairyDate" +
                ")";

            using SqlConnection connection = new(_connectionString);
            connection.Open();
            SqlCommand cmd = new(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@expairyDate", DateTime.Now);

            var res = cmd.ExecuteNonQuery();

            /*                $"insert into EmployeeAttendance(EmployeeCode, EntryTime)" +
                            $"values((select ID from Employees where EmployeeNat = '{id}'), '{date.ToShortDateString()}')
            */

        }

        private static void UpdateExit(string id)
        {



            string query = "UPDATE EmployeeAttendance " +
                            "SET ExitTime = " +
                            "@exitTime" +
                            " WHERE ExitTime is null and EmployeeCode =" +
                            " (select ID from Employees where EmployeeNat = @id); ";

            using SqlConnection connection = new(_connectionString);
            connection.Open();
            SqlCommand cmd = new(query, connection);

            cmd.Parameters.AddWithValue("@exitTime", DateTime.Now);
            cmd.Parameters.AddWithValue("@id", id);

            var res = cmd.ExecuteNonQuery();

            
        }
        private void ClockForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (!(IsExitNull(labelIdentetyNumber.Text)))
            {
                MessageBox.Show("you are already in");
                return;
            }
            else
            {
                DateTime d = DateTime.Now;
                labelEnteryDate.Text = d.ToString();
                InsertEnter(d, labelIdentetyNumber.Text);
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)

        {
            if (IsExitNull(labelIdentetyNumber.Text))
            {
                MessageBox.Show("you didnt enter");
                return;
            }
            else
            {
                UpdateExit(labelIdentetyNumber.Text);
                DateTime d = DateTime.Now;
                labelExitDate.Text = d.ToString();
            }
            
        }
    }
}
