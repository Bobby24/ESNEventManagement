using System;
using Microsoft.Data.SqlClient;

namespace EventManagementSystem
{
    public class DBHandler
    {
        public static void TryDBConnection()
        {
            // Define integrated security for using Windows Authernticator
            string connectionString = "Server=WildFire;Database=ESNRomania;User Id=user_bobby;Password=user_bobby;Trusted_Connection=true;";

            // Create a connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();
                    Console.WriteLine("Connection opened successfully.");

                    // Execute a simple query
                    /*string query = "SELECT COUNT(*) FROM Events";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowCount = (int)command.ExecuteScalar();
                        Console.WriteLine($"Row count: {rowCount}");
                    }*/
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine("Connection closed.");
                }
            }
        }
    }
}