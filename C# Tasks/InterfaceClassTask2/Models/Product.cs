namespace InheritanceTask2.Models;
using Base;

internal class Product : BaseEntity
{
    public int CategoryId { get; set; }
    public string ProductDescription { get; set; }
    public decimal ProductPrice { get; set; }
    public int ProductAmount { get; set; }
    public int ProductUnitsinStock { get; set; }
}
