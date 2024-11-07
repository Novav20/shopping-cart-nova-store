using System;

namespace ShoppingCart.Entities;

public class UsersViewModel
{
    public IEnumerable<User>? Users { get; set; }
    public User? NewUser { get; set; }
}
