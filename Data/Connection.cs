using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace ShoppingCart.Data
{
    public class Connection
    {
        private readonly string _connectionString;

        public Connection(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }

        // Método para verificar si se puede conectar a la base de datos
        public bool TestConnection()
        {
            try
            {
                using var connection = new SqlConnection(_connectionString);
                connection.Open();
                return true; // La conexión fue exitosa
            }
            catch
            {
                return false; // Fallo en la conexión
            }
        }
    }
}
