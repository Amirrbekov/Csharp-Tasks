namespace InheritanceTask2.Models;

internal class Customer : Base
{
    public string CustomerFirstName { get; set; }
    public string CustomerLastName { get; set; }
}

internal class CustomerMail : Base
{
    public string CustomerMailTitle { get; set; }
    public string CustomerMailEmail { get; set; }
}

internal class CustomerAddress : Base
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

internal class CustomerPhone : Base
{
    public int CustomerId { get; set; }
    public string CustomerPhoneAreaCode { get; set; }
    public int CustomerPhoneNumber { get; set; }
}