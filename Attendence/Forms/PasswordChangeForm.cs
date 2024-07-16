using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendence.Dal;

namespace Attendence
{
    public partial class PasswordChangeForm : Form
    {
      public string GetNameByTz(string name)
        {
            DBContext db = new DBContext();
            var a = db.MakeQuery($"select FirstName from Employees where  EmployeeNat = '{name}'");
            var b = a.Rows[0][0].ToString();
            return b;
        }
        public void ChangeNewToNewPassword(string newPassword, string tz)
        {
            DBContext db = new DBContext();
            db.MakeQuery($"UPDATE Passwords SET EmployeePassword = '{newPassword}' WHERE EmployeeID = (select ID from Employees where EmployeeNat = '{tz}');");
        }
        public bool CheckTwoPasswords(string password1, string password2)
        {
            return (password1 == password2);
        }
        
        public PasswordChangeForm()
        {
            InitializeComponent();
        }

        private void linkLabelCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Close();

        }

        private void buttonChangeNewPassword_Click(object sender, EventArgs e) { 

            if (CheckTwoPasswords(textBoxNewPassword.Text, GetNameByTz(textBoxTz.Text)) ||
                LoginForm.CheckIdPassword(textBoxOldPssword.Text, textBoxTz.Text))
            {
                MessageBox.Show("incorrect ditails");
                return;
            }
            else
            {
                ChangeNewToNewPassword(textBoxNewPassword.Text, textBoxTz.Text);
                MessageBox.Show("you have changed your password!");
                LoginForm loginForm = new LoginForm();

                this.Close();
    }
}

        private void PasswordChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
