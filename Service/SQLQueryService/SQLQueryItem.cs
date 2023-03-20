using RazorPageVersion2022.Models;
using System.Data.SqlClient;

namespace RazorPageVersion2022.Service.SQLQueryService
{
    public class SQLQueryItem
    {
        static string ConnectionString = "";

        public static List<Item> GetAllItems()
        {
            List<Item> itemsList = new List<Item>();
            string query = "";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item item = new Item();
                        item.Id = Convert.ToInt32(reader[0]);
                        item.Name = Convert.ToString(reader[1]);
                        item.Price = Convert.ToInt32(reader[2]);
                        itemsList.Add(item);
                    }
                }                
            }
            return itemsList;
        }



    }
}
