using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace databaseTesting
{
    internal class databaseOperations
    {

        private static string getConnectionString()
        {
            string host = "Host=localhost;";
            string port = "Port=5432;";
            string dbName = "Database=vanierAECWinter2023;";
            string userName = "Username=postgres;";
            string password = "Password=1234;";
            // Now we need to add all these values/strings to one string, means we are going to merge
            // the strings together and going to create our string
            string connectionString = string.Format("{0}{1}{2}{3}{4}", host, port, dbName, userName, password);
            return connectionString;
        }

        // create connector
        public static NpgsqlConnection con;
        public static NpgsqlCommand cmd;

        // connection establishment

        private static void connectionEstablish()
        {
            try
            {
                con = new NpgsqlConnection(getConnectionString());
                MessageBox.Show("Connection Established");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void addData(string name, int age, string email)
        {
            connectionEstablish();
            
                con.Open();
                string Query = "insert into customer values(@name, @age, @email)";
                cmd = new NpgsqlCommand(Query, con);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@email", email);

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Data Inserted Successfully");
                }
                con.Close();
            
        }

        public static string[] selectLastData(string email)
        {
            connectionEstablish();
            con.Open();
            string Query = "select * from customer where @email=email";
            cmd = new NpgsqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@email", email);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string[] dataRetrieve = new string[3];

            if (dt.Rows.Count > 0)
            {
                dataRetrieve[0] = (string)dt.Rows[0][0];
                dataRetrieve[1] = dt.Rows[0][1].ToString();
                dataRetrieve[2] = (string)dt.Rows[0][2];
            }

            return dataRetrieve;
        }
    }
}
