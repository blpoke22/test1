using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BetterOOinCSharp
{
    /*
     * Task 2.1.2
     */
    abstract class Agency
    {
        private const string db = "kit206";
        private const string user = "kit206";
        private const string pass = "kit206"; 
        private const string server = "alacritas.cis.utas.edu.au";

        private static MySqlConnection conn = null;

        private static MySqlConnection GetConnection()
        {
            if(conn == null)
            {
                string connectionString =
                    String.Format("Database ={0};Data Source={1};User Id={2}; Password={3}"
                    , db, server, user, pass);

                conn = new MySqlConnection(connectionString);
            }
            return conn;
        }

        public static List<Employee> loadAll()
        {
            MySqlConnection conn = GetConnection();
            MySqlDataReader rdr = null;

            List<Employee> employees = new List<Employee>();

            try
            {
                // Open the connection
                conn.Open();

                // 1. Instantiate a new command with a query and connection
                MySqlCommand cmd = new MySqlCommand("select id, given_name, family_name from researcher", conn);

                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();

                // print the CategoryName of each record
                while (rdr.Read())
                {
                    //This illustrates how the raw data can be obtained using an indexer [] or a particular data type can be obtained using a GetTYPENAME() method.
                    employees.Add( new Employee { ID = rdr.GetInt32(0), Name = String.Format("{0} {1}", rdr.GetString(1), rdr.GetString(2)) });
                }
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return employees;
        }
        public static List<Employee> Generate()
        {
            return new List<Employee>() {
                new Employee { Name = "Jane", ID = 1, Gender = Gender.F },
                new Employee { Name = "John", ID = 3, Gender = Gender.M },
                new Employee { Name = "Mary", ID = 7, Gender = Gender.F },
                new Employee { Name = "Lindsay", ID = 5, Gender = Gender.X },
                new Employee { Name = "Meilin", ID = 2, Gender = Gender.F }
            };
        }
    }
}
