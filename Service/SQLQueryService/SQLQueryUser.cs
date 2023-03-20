using RazorPageVersion2022.Models;
using System.Data.SqlClient;

namespace RazorPageVersion2022.Service.SQLQueryService
{
    public class SQLQueryUser
    {
        static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RazorPageVersion2022DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public static List<User> GetAllUser()
        {
            List<User> userList = new List<User>();
            string query = "Select * from Users";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.UserName = Convert.ToString(reader[0]);
                        user.Password = Convert.ToString(reader[1]);
                        userList.Add(user);
                    }
                }
            }
            return userList;
        }

        public static void AddUser(User user)
        {
            string query = "INSERT INTO Users (UserName, Password) VALUES (@UserName, @Password)";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                {
                    command.Parameters.AddWithValue("@UserName", user.UserName);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    int affectedRows = command.ExecuteNonQuery();
                }
            }
        }

    }
}
