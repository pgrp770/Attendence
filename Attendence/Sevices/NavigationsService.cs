using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendence.Sevices
{
    internal static class NavigationsService
    {

        public static bool isNavigating = false;
        private static void CloseAllForms()
        {
            isNavigating = true;
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            foreach (Form item in openForms)
            {
                item.Close();
            }
            isNavigating = false;
        }

        public static void SohwForm(string formName, string workerIdentity="dsfa")
        {
            CloseAllForms();
            Form form = formName switch
            {
                "LoginForm" => new LoginForm(),
                "PasswordCangeForm" => new PasswordChangeForm(),
                "ClockForm" => new ClockForm(workerIdentity),
                _ => throw new ArgumentException("Invalid form name.", nameof(formName))

            };
            form.Show();

        }
    }
}
