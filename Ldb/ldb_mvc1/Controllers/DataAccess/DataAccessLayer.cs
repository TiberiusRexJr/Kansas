using ldb_mvc1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ldb_mvc1.Controllers.DataAccess
{
    
    public class DataAccessLayer

    {
        #region Variables
        private readonly string _server = "etechenterprises.database.windows.net";
        private readonly string _userId = "Ravenone1";
        private readonly string _password = "supersix5!";
        private readonly string _database = "ldb";
        private readonly string _procedureName = "dbo.CRUD";
        #endregion
        #region Properties
        private SqlConnection DbConnection { get; set; }
        #endregion
        #region Contructor
        public DataAccessLayer()
        {
            SetConnection();
        }
        #endregion
        #region Functions
        private void SetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = _server;
            builder.UserID = _userId;
            builder.Password = _password;
            builder.InitialCatalog = _database;

            try 
            {
                 DbConnection= new SqlConnection(builder.ConnectionString);
                    
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public string Insert(UserProfile user)
        {
            SqlCommand cmd = new SqlCommand(_procedureName, DbConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            int queryCode = 1;
            string result = null;

            cmd.Parameters.AddWithValue("@id",0);
            cmd.Parameters.AddWithValue("@firstname", user.firstName);
            cmd.Parameters.AddWithValue("@middlename", user.middleName);
            cmd.Parameters.AddWithValue("@lastname", user.lastName);
            cmd.Parameters.AddWithValue("@sex", user.sex);
            cmd.Parameters.AddWithValue("@dob", user.dob);
            cmd.Parameters.AddWithValue("@phone", user.phone);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@department", user.department);
            cmd.Parameters.AddWithValue("@userPictureUrl", user.userPictureUrl);
            cmd.Parameters.AddWithValue("@age", user.age);
            cmd.Parameters.AddWithValue("@query", queryCode);

            try
            {
                DbConnection.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch(Exception e)
            {
                return result = "fuck you hoe";
            }
            finally
            {
                DbConnection.Close();
            }

        }

        public string Update(UserProfile user)
        {
            SqlCommand cmd = new SqlCommand(_procedureName, DbConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            int queryCode = 2;
            string result = null;

            #region Adding Parameters
            cmd.Parameters.AddWithValue("@id", user.id);
            cmd.Parameters.AddWithValue("@firstname", user.firstName);
            cmd.Parameters.AddWithValue("@middlename", user.middleName);
            cmd.Parameters.AddWithValue("@lastname", user.lastName);
            cmd.Parameters.AddWithValue("@sex", user.sex);
            cmd.Parameters.AddWithValue("@dob", user.dob);
            cmd.Parameters.AddWithValue("@phone", user.phone);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@department", user.department);
            cmd.Parameters.AddWithValue("@userPictureUrl", user.userPictureUrl);
            cmd.Parameters.AddWithValue("@age", user.age);
            cmd.Parameters.AddWithValue("@query", queryCode);
            #endregion

            try
            {
                DbConnection.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch (Exception e)
            {
                return result = "fuck you hoe";
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public string DeleteData(UserProfile user)
        {
            #region variables
            SqlCommand cmd = new SqlCommand(_procedureName,DbConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            int queryCode = 3;
            string result = null;
            #endregion
            #region Setting Command parameters
            cmd.Parameters.AddWithValue("@id", user.id);
            cmd.Parameters.AddWithValue("@firstname", null);
            cmd.Parameters.AddWithValue("@middlename", null);
            cmd.Parameters.AddWithValue("@lastname", null);
            cmd.Parameters.AddWithValue("@sex", null);
            cmd.Parameters.AddWithValue("@dob", null);
            cmd.Parameters.AddWithValue("@phone", null);
            cmd.Parameters.AddWithValue("@email", null);
            cmd.Parameters.AddWithValue("@department", null);
            cmd.Parameters.AddWithValue("@userPictureUrl", null);
            cmd.Parameters.AddWithValue("@age", null);
            cmd.Parameters.AddWithValue("@query", queryCode);
            #endregion

            #region Exectution
            try
            {
                DbConnection.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch (Exception e)
            {
                return result = "fuck you hoe";
            }
            finally
            {
                DbConnection.Close();
            }
            #endregion
        }

        public List<UserProfile> RetrieveProfiles()
        {
            #region Variables
            DataSet dataset = new DataSet();
            SqlDataAdapter DataAdapter = new SqlDataAdapter();
            List<UserProfile> ListUserProfiles = null;


            SqlCommand cmd = new SqlCommand(_procedureName, DbConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            int queryCode = 4;

            #endregion

            #region Setting Paramters
            cmd.Parameters.AddWithValue("@id", null);
            cmd.Parameters.AddWithValue("@firstname", null);
            cmd.Parameters.AddWithValue("@middlename", null);
            cmd.Parameters.AddWithValue("@lastname", null);
            cmd.Parameters.AddWithValue("@sex", null);
            cmd.Parameters.AddWithValue("@dob", null);
            cmd.Parameters.AddWithValue("@phone", null);
            cmd.Parameters.AddWithValue("@email", null);
            cmd.Parameters.AddWithValue("@department", null);
            cmd.Parameters.AddWithValue("@userPictureUrl", null);
            cmd.Parameters.AddWithValue("@age", null);
            cmd.Parameters.AddWithValue("@query", queryCode);
            #endregion

            #region TryExectution
            try
            {
                DbConnection.Open();
                DataAdapter.SelectCommand = cmd;
                DataAdapter.Fill(dataset);
                
                foreach(DataTable table in dataset.Tables )
                {
                    foreach(DataRow row  in table.Rows)
                    {
                        UserProfile user = new UserProfile();

                        user.id = row.Field<int>("Id");
                        user.firstName = row.Field<string>("FirstName");
                        user.lastName = row.Field<string>("LastName");

                        ListUserProfiles.Add(user);
                    }
                }

                return ListUserProfiles;
            }
            catch (Exception e)
            {
                return ListUserProfiles;
            }
            finally
            {
                DbConnection.Close();
            }
            #endregion

           
        }
        public UserProfile RetrieveByEmail(string userId)
        {
            #region Variables
            DataSet dataSet = new DataSet();
            UserProfile user=new UserProfile();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();


            SqlCommand cmd = new SqlCommand(_procedureName,DbConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            int queryCode = 5;

            #endregion
            #region CommandParameters
            cmd.Parameters.AddWithValue("@id", userId);
            cmd.Parameters.AddWithValue("@firstname", null);
            cmd.Parameters.AddWithValue("@middlename", null);
            cmd.Parameters.AddWithValue("@lastname", null);
            cmd.Parameters.AddWithValue("@sex", null);
            cmd.Parameters.AddWithValue("@dob", null);
            cmd.Parameters.AddWithValue("@phone", null);
            cmd.Parameters.AddWithValue("@email", null);
            cmd.Parameters.AddWithValue("@department", null);
            cmd.Parameters.AddWithValue("@userPictureUrl", null);
            cmd.Parameters.AddWithValue("@age", null);
            cmd.Parameters.AddWithValue("@query", queryCode);
            #endregion
            #region TryExectution
            try
            {
                DbConnection.Open();
                sqlDataAdapter.SelectCommand = cmd;
                sqlDataAdapter.Fill(dataSet);

                foreach(DataTable table in dataSet.Tables)
                {
                    foreach(DataRow row in table.Rows)
                    {
                        user.firstName = row.Field<string>("FirstName");
                        user.email = row.Field<string>("Email");
                    }
                }

                return user;
            }
            catch (Exception e)
            {
                return user;
            }
            finally
            {
                DbConnection.Close();
            }
            #endregion
            throw new NotImplementedException();
        }
        #endregion


    }
}
