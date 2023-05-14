namespace InheritanceTask.Models;

internal class Student : Person
{
    private int iqrank;
    private int languagerank;

    public int IQRank
    {
        get => iqrank;
        set
        {
            if (value > 100)
            {
                throw new ArgumentException("Rank in IQ cannot be more than 100.");
            }
            else if (value < 0)
            {
                throw new ArgumentException("Rank in IQ cannot be less than zero.");
            }
            iqrank = value;
        }
    }

    public int LanguageRank
    {
        get => languagerank;
        set
        {
            if (value > 100)
            {
                throw new ArgumentException("Rank in Language cannot be more than 100.");
            }
            else if (value < 0)
            {
                throw new ArgumentException("Rank in Language cannot be less than zero.");
            }
            languagerank = value;
        }

    }
    public int ExamResult()
    {
        int result = LanguageRank + IQRank;

        if (result < 120)
        {
            throw new InvalidOperationException("I'm sorry you didn't pass the exam");
        }
        if (Age < 6)
        {
            throw new InvalidOperationException("Under 6 students are not allowed to exam.");
        }
        else if (Age > 20)
        {
            throw new InvalidOperationException("Above 20 students are not allowed to exam.");
        }
        return result;
    }

    public Student(string name, string surname, int age, int IQrank, int Languagerank)
    {
        Name = name;
        Surname = surname;
        Age = age;
        IQRank = IQrank;
        LanguageRank = Languagerank;
    }
}
