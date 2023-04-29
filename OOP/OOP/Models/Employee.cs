namespace OOP.Models;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Mail { get => $"{this.FirstName}.{this.LastName}@code.edu.az".ToLower(); }

    public string Address { get; set; }
    public string City { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime HireDate { get; set; }
    public string Linkedin { get; set; }


    // encapsulation
    private byte _age;
    public byte Age
    {
        get => _age;
        set
        {
            if (value < 18)
            {
                throw new Exception("18 yasdan asagi giris qadagandir!");
            }
            _age = value;
        }
    }
}
