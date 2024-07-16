using System.Data;
using Attendence.Dal;
using Attendence.Sevices;
using Microsoft.Extensions.Configuration;


namespace Attendence
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // SET SECRETS.JSON TO COPY ALWAYS AFTER ADDING!!
            IConfiguration builder = new ConfigurationBuilder()
                .AddJsonFile("secretJson.json", optional: true) // Add secrets.json
                .Build();
            // Read a value from the configuration
            string connString = builder["connectionString"];
            Console.WriteLine($"The secret value is: {connString}");
            
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            NavigationsService.SohwForm("LoginForm");
            LoginForm loginForm = new LoginForm();
            
/*            loginForm.Show();*/
            Application.Run();
        }
    }
}