using System.Xml.Linq;

namespace LibaryTask.Models;

internal class Libary
{
    private Books[] books = new Books[0];
    public static int BookCount { get; set; } = 0;

    public void AddBook(Books book)
    {
        Array.Resize(ref books, BookCount + 1);
        books[BookCount] = book;
        BookCount++;
    }
    public Books GetBook(string name)
    {
        for (int i = 0; i < BookCount; i++)
        {
            if (books[i].Name == name)
            {
                return books[i];
            }
        }

        return null;
    }
    public Books[] FindAllBooks()
    {
        Books[] foundBooks = new Books[BookCount];
        Array.Copy(books, foundBooks, BookCount);
        return foundBooks;
    }
    public int RemoveAllBook(string name) 
    {
        int count = 0;

        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] != null && books[i].Name.Contains(name))
            {
                books[i] = null;
                count++;
            }
        }

        return count;
    }
}
