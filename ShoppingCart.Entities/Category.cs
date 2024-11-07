namespace ShoppingCart.Entities;

public class Category
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool Active { get; set; } = true;
}

