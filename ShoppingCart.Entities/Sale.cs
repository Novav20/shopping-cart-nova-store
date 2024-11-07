namespace ShoppingCart.Entities;

public class Sale
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public int NumberOfProducts { get; set; }
    public decimal Total { get; set; }
    public string Contact { get; set; } = string.Empty;
    public string DistrictId { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string TransactionId { get; set; } = string.Empty;
    public List<SaleDetail> SaleDetails { get; set; } = [];
}

