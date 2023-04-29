using OOP.Models;

namespace OOP;
public static class Program
{
    public static void Main(String[] args)
    {
		try
		{
			Employee employee = new Employee();
			employee.FirstName = "Valeh";
			employee.LastName = "Amirbekov";
			employee.Age = 17;

            Console.WriteLine($"""
				FirstName  : {employee.FirstName}
				LastMName  : {employee.LastName}
				Age        : {employee.Age}
				Mail       : {employee.Mail}


				""");
        }
		catch (Exception ex)
		{

            Console.WriteLine(ex.Message);
        }

    }
}