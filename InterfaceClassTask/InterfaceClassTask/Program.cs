using InterfaceClassTask.Models;

namespace InterfaceClassTask;

public static class Program
{
    public static void Main(String[] args)
    {
        User user = new();
        user.FullName = "Valeh";
        user.Email = "amirbekovaleh@gmail.com";
        user.Password = "password";
        user.ShowInfo();
        User user1 = new();
        user1.FullName = "Valero";
        user1.Email = "amirbekovvaleh04@icloud.com";
        user1.Password = "pasS1word!1";
        user1.ShowInfo();
    }
}