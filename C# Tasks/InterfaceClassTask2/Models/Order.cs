namespace InheritanceTask2.Models;
using Base;

internal class Order : BaseEntity
{
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime DeliveredDate { get; set; }
    public int ShipperId { get; set; }
    public int CustomerAddressId { get; set; }
    public string Status { get; set; }
}

internal class OrderDetail : BaseEntity
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
    public decimal Discount { get; set; }
}