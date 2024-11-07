using System.Data.SqlClient;
using ShoppingCart.Entities;

namespace ShoppingCart.Data;

public class UserRepository(Connection connection)
{
    private readonly Connection _connection = connection;

    public List<User> GetUsers()
    {
        List<User> users = [];
        try
        {
            using SqlConnection connection = new(_connection.GetConnectionString());
            connection.Open();

            string query = "SELECT Id, FirstName, LastName, Email, Password, Reset, Active FROM Users";
            using SqlCommand command = new(query, connection);
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Email = reader.GetString(3),
                    Password = reader.GetString(4),
                    Reset = reader.GetBoolean(5),
                    Active = reader.GetBoolean(6)
                });
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return users;
    }
}
