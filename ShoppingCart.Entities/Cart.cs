namespace ShoppingCart.Entities;

public class Cart
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}
