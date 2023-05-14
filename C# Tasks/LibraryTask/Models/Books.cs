namespace LibraryTask.Models;

public class Books
{
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public int PageCount { get; set; }
    public decimal Price { get; set; }
    public string Code { get; set; }

    public Books(string name, string authorname, int pagecount, decimal price)
    {
        Name = name;
        AuthorName = authorname;
        PageCount = pagecount;
        Price = price;
        int i = 0;

        string[] words = name.Split(' ');
        string code = "";

        foreach (string word in words)
        {
            code += Char.ToUpper(word[0]);
        }
        code += "-" + (++i);
        Code = code;
    }
}
