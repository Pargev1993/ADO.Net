using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace ADO.NETExenples
{
    class Program
    {
        static void Main(string[] args)
        {
             string Connect= @" Data Source =(localdb)\MSSQLLocalDB; Initial Catalog = Fifadb; Integrated Security = True";
            using (SqlConnection sqlConnection=new SqlConnection (Connect))
            {
                try
                {
                    sqlConnection.Open();
                    Console.WriteLine(sqlConnection.State);
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }
    }
}
