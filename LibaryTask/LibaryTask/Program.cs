namespace LibaryTask;
using Models;

public static class Program
{
    public static void Main(String[] args)
    {
        Libary library = new Libary();

        Books book1 = new Books("The Catcher in the Rye", "J.D. Salinger", 224, 12.99m);
        Books book2 = new Books("To Kill a Mockingbird", "Harper Lee", 336, 9.99m);
        Books book3 = new Books("1984", "George Orwell", 328, 8.99m);

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        Books[] allBooks = library.FindAllBooks();
        foreach (Books book in allBooks)
        {
            Console.WriteLine($"Name: {book.Name}, Author: {book.AuthorName}, Price: {book.Price}, Code: {book.Code}");
        }

        Books bookFound = library.GetBook("1984");
        Console.WriteLine($"Book Found: {bookFound.Name}");
    }
}