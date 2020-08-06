using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Hosting;

namespace ldb_mvc1.Models
{
    public class db
    {
        #region Properties

        #endregion

        #region Costructor

        #endregion

        #region Fuctions
        public void Connection()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource= "etechenterprises.database.windows.net";
                builder.UserID = "Ravenone1";
                builder.Password = "Supersix1!";
                builder.InitialCatalog = "ldb";

                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                connection.Open();

                StringBuilder sb = new StringBuilder();
                sb.Append("");
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
        #endregion

    }


}
