using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Extensions.Configuration;

namespace Attendence.Dal
    
{
    internal class DBContext
    {
        public static  string _connectionString;
        public DBContext()
        {
            _connectionString = GetConnString();
        }

        /*
            private string _connectionString;
           public DBcontext()
           {
               _connectionString = GetConnString();
           }

           private string GetConnString()
           {
               IConfiguration builder = new ConfigurationBuilder()
                .AddJsonFile("secrets.json", optional: true) // Add secrets.json
                .Build();

               string cs = builder["ConnectionString"];
               if (string.IsNullOrEmpty(cs)) throw new Exception("Cannot read conn striong from secrets");
               return cs!;
           }*/

        private string GetConnString()
        {
            IConfiguration builder = new ConfigurationBuilder()
             .AddJsonFile("secrets.json", optional: true) // Add secrets.json
             .Build();

            string cs = builder["connectionString"];
            if (string.IsNullOrEmpty(cs)) throw new Exception("Cannot read conn striong from secrets");
            return cs!;
        }
        public DataTable MakeQuery(string queryStr)
        {
            DataTable output = new ();

            using (SqlConnection conn = new (_connectionString))
            using (SqlCommand cmd = new (queryStr, conn))
            {
                try
                {
                    conn.Open();
                    using SqlDataAdapter adapter = new (cmd);
                    adapter.Fill(output);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
       
            }
        return output;
        }
    }
}
