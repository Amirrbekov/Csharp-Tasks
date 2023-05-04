using InterfaceClassTask.Interface;
using System.Security.Cryptography;

namespace InterfaceClassTask.Models;

public class User : IAccount
{
    private static int _id;
    public int Id { get => _id++; }
    public string FullName { get; set; }
    private string _email;
    public string Email
    {
        get => _email;

        set
        {
            if (!string.IsNullOrWhiteSpace(value)) _email=value;
        }
    }
    private string _password;
    public string? Password
    {
        get => _password;

        set
        {
            if (PasswordChecker(value)) _password = value;
        }
    }

    public bool PasswordChecker(string password)
    {
        bool isLower = false;
        bool isDigit = false;
        bool isUpper = false;
        if (password.Length >= 8)
        {
            foreach (char charac in password)
            {
                if (char.IsDigit(charac)) isDigit = true;
                else if (char.IsLower(charac)) isLower = true;
                else if(char.IsUpper(charac)) isUpper = true;
                if (isLower && isDigit && isUpper) return true;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("- şifrədə minimum 8 character olmalıdır");
            Console.ResetColor();
            return false;
        }
        if (!isDigit || !isLower || !isUpper)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("""
                - şifrədə ən az 1 böyük hərf olmalıdır
                - şifrədə ən az 1 kiçik hərf olmalıdır
                - şifrədə ən az 1 rəqəm olmalıdır
                """);
            Console.ResetColor();
            return false;
        }
        return false;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"""
            ID       : {Id}
            FullName : {FullName}
            Email    : {Email}
            """);
    }
}