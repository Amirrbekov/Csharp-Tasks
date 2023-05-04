using Enum_Display.Models;

namespace Enum_Display;

public static class Program
{
    public static void Main(String[] args)
    {
        Customers customers = new();
        customers.DisplayName();
    }
}