namespace LibaryTask.Models;

internal class Order
{
    public int Id { get; set; }
    public Books[] books { get; set; } = new Books[0];
    public decimal TotalPrice { get; set; } = 0;
    public DateTime Date { get; set; } = DateTime.Now;

    public Order(int id, Books[] book, DateTime date)
    {
        Id = id;
        books = book;
        Date = date;

        foreach (Books bookl in books)
        {
            TotalPrice += bookl.Price;
        }
        if (TotalPrice < 100)
        {
            TotalPrice *= 1.0m;
        }
        else if (TotalPrice < 200)
        {
            TotalPrice *= 0.9m;
        }
        else
        {
            TotalPrice *= 0.8m;
        }
    }
}
