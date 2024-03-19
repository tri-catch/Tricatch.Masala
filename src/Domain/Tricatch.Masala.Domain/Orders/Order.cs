namespace Tricatch.Masala.Domain.Orders;

public class Order
{
    public int Id { get; set; }

    public string OrderedItemIds { get; set; } = string.Empty;

    public decimal SubTotalPrice { get; set; }
    
    public decimal TaxAmount { get; set; }

    public decimal TotalPrice { get; set; }

    public string CustomerPhoneNumber { get; set; } = string.Empty;

    public string CustomerEmail { get; set; } = string.Empty;
}