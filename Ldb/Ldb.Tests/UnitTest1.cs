using System;
using System.Text;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ldb.Tests
{
    [TestClass]
    public class UnitTest1
    {
        /*   builder.DataSource = "etechenterprises.database.windows.net";
                builder.UserID = "Ravenone1";
                builder.Password = "Supersix1!";
                builder.InitialCatalog = "ldb";*/
        [TestMethod]
        public void Connection()
        {
              try
            {
                //create a SQL builder string with all required field neccesary to connect to my database
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource= "etechenterprises.database.windows.net";
                builder.UserID = "Ravenone1";
                builder.Password = "Supersix1!";
                builder.InitialCatalog = "ldb";

                //create a SqlConnection using the builder string from the previous string and open connection
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                connection.Open();

                //create a stringbuilder object and append query string to it.
                StringBuilder sb = new StringBuilder();

                /*sb.Append("SELECT TOP 20 pc.Name as CategoryName, p.name as ProductName ");
                sb.Append("FROM [SalesLT].[ProductCategory] pc ");
                sb.Append("JOIN [SalesLT].[Product] p ");
                sb.Append("ON pc.productcategoryid = p.productcategoryid;");*/

                sb.Append("");
                
                //create a regular string and set it equal to the string value of sb, StringBuilder
                string sql = sb.ToString();

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                {
                    Console.WriteLine(reader.GetString(0), reader.GetString(1));
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
