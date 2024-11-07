using ShoppingCart.Data; // Donde están los repositorios
using ShoppingCart.Entities; // Donde están las entidades

namespace ShoppingCart.Business
{
    public class UserService(UserRepository userRepository)
    {
        private readonly UserRepository _userRepository = userRepository;
        public List<User> GetUsers() => _userRepository.GetUsers();
        public List<User> GetAllActiveUsers()
        {
            var users = _userRepository.GetUsers();
            return users.Where(user => user.Active).ToList(); // Lógica de negocio adicional
        }


        public bool ValidateUserCredentials(string email, string password)
        {
            var user = _userRepository.GetUsers().FirstOrDefault(u => u.Email == email);
            if (user == null)
                return false;

            // Podrías aplicar aquí una encriptación o hash para validar las credenciales
            return user.Password == password;
        }
    }
}