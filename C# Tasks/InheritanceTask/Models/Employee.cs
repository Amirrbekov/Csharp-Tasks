using System.Xml.Linq;

namespace InheritanceTask.Models;

internal class Employee : Person
{
    private decimal salaryOfHour;
    private int workingHour;

    public decimal SalaryOfHour
    {
        get => salaryOfHour;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Salary of hour cannot be less than or equal to zero.");
            }

            salaryOfHour = value;
        }
    }
    public int WorkingHour
    {
        get => workingHour;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Working hour cannot be less than or equal to zero.");
            }

            if (value > 8 * 30)
            {
                throw new ArgumentException("Average daily working hour cannot exceed 8 hours.");
            }

            workingHour = value;
        }
    }

    /// <summary>
    /// Calculate Salary
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public decimal CalculateSalary()
    {
        decimal salary = SalaryOfHour * WorkingHour;

        if (salary < 250)
        {
            salary = 250;
        }

        if (Age < 18)
        {
            throw new InvalidOperationException("Under 18 employees are not allowed to work.");
        }

        return salary;
    }

    public Employee(string name, string surname, int age, decimal salaryofhour, int workinghour)
    {
        Name = name;
        Surname = surname;
        SalaryOfHour = salaryofhour;
        WorkingHour = workinghour;
    }
}
