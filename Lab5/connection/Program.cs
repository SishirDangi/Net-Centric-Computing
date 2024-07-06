using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Server=DESKTOP-9TJNSEL\\SQLEXPRESS;Database=TestDB;Trusted_Connection=True;";

        // Connected Architecture
        Console.WriteLine("Connected Architecture:");
        ConnectedArchitecture(connectionString);

        // Disconnected Architecture
        Console.WriteLine("\nDisconnected Architecture:");
        DisconnectedArchitecture(connectionString);
    }

    static void ConnectedArchitecture(string connectionString)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Users";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}");
                    }
                }
            }
        }
    }

    static void DisconnectedArchitecture(string connectionString)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Users";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Users");

            DataTable usersTable = dataSet.Tables["Users"];
            foreach (DataRow row in usersTable.Rows)
            {
                Console.WriteLine($"Id: {row["Id"]}, Name: {row["Name"]}");
            }
        }
    }
}
