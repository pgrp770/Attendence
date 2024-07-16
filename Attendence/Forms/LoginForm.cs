using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendence.Sevices;
using Attendence.Dal;
using System.Reflection.Metadata.Ecma335;
using System.Web;


namespace Attendence
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            
            

        }
/*        public void Demo()
        {
            DataTable dt = _dbContext.MakeQuery("SELECT * from Employees;");
            MessageBox.Show(dt.Rows[0]["result"].ToString());
        }*/
        public static bool CheckIdPassword(string password, string firstName)
        {
            DBContext _dbContext = new DBContext();
            var res = _dbContext.MakeQuery($"select * " +
                $"                         from Employees" +
                $"                          Join Passwords on Passwords.EmployeeID = Employees.ID" +
                $"                          where FirstName = '{firstName}' and EmployeePassword = '{password}';");
            return (!(res.Rows.Count == 0));
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public static string? GetTzByName(string tz)
        {
            DBContext db = new DBContext();
            var a = db.MakeQuery($"select EmployeeNat from Employees where FirstName = '{tz}'");
            var b = a.Rows[0][0].ToString();
            return b;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (CheckIdPassword(textBoxPassword.Text, textBoxUserName.Text))
            {

            NavigationsService.SohwForm("ClockForm", GetTzByName(textBoxUserName.Text));
            }
            else
            {
                MessageBox.Show("incorect password or username");
                return;
            }
/*            this.Hide();
            ClockForm clockform = new ClockForm();
            clockform.Show();*/
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordChangeForm passwordchangeform = new PasswordChangeForm();
            passwordchangeform.Show();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!NavigationsService.isNavigating)
            {
                Application.Exit();
            }
            
        }
    }
}
