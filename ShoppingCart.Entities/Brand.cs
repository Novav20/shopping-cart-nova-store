namespace ShoppingCart.Entities;

public class Brand
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool Active { get; set; } = true;
}
