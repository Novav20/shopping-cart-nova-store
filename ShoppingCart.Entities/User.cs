using System.ComponentModel;

namespace ShoppingCart.Entities;

public class User
{
    [DisplayName("ID")]
    public int Id { get; set; }
    [DisplayName("Nombre")]
    public string FirstName { get; set; } = string.Empty;
    [DisplayName("Apellido")]
    public string LastName { get; set; } = string.Empty;
    [DisplayName("Correo Electrónico")]
    public string Email { get; set; } = string.Empty;
    [DisplayName("Contraseña")]
    public string Password { get; set; } = string.Empty;
    [DisplayName("Restablecer")]
    public bool Reset { get; set; } = true;
    [DisplayName("Estado")]
    public bool Active { get; set; } = true;
}
