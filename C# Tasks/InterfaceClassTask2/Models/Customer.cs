namespace InheritanceTask2.Models;
using Base;

internal class Customer : BaseEntity
{
    public string CustomerFirstName { get; set; }
    public string CustomerLastName { get; set; }
}

internal class CustomerMail : BaseEntity
{
    public string CustomerMailTitle { get; set; }
    public string CustomerMailEmail { get; set; }
}

internal class CustomerAddress : BaseEntity
{
    public int CustomerId { get; set; }
    public string CustomerAddressTitle { get; set; }
    public string CustomerAddressCountry { get; set; }
    public string CustomerAddressCity { get; set; }
    public string CustomerAddressTown { get; set; }
    public string CustomerAddressStreet { get; set; }
    public string CustomerAddressBuilding { get; set; }
    public int CustomerAddressNo { get; set; }
}

internal class CustomerPhone : BaseEntity
{
    public int CustomerId { get; set; }
    public string CustomerPhoneAreaCode { get; set; }
    public int CustomerPhoneNumber { get; set; }
}