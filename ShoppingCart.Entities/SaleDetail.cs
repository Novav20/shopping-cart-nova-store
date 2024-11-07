namespace ShoppingCart.Entities;

public class SaleDetail
{
    public int Id { get; set; }
    public int SaleId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Total { get; set; }
    public string TransactionId { get; set; } = string.Empty;
}