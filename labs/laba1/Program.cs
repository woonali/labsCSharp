Student Anna = new ("Anna");
Student Nikita = new("Nikita", 15);
Nikita.WriteInfo();
Nikita.BecameOlder();
Nikita.BecameOlder();
Nikita.BecameOlder();
Nikita.BecameOlder();
Nikita.WriteInfo();
Anna.WriteInfo();

public class Student
{
    private string? _name { get; set; }
    public int? Age { get; set; }

    public Student(string _name, int Age)
    {
        this._name = _name;
        this.Age = Age;
    }

    public Student(string _name)
    {
        this._name = _name;
    }

    public void WriteInfo()
    {
        string str = "";
        if (!string.IsNullOrEmpty(this._name))
        {
            str = $"Имя студента - {this._name}";
        }
        if (this.Age.HasValue)
        {
            str += $", возраст студента - {this.Age}";
        }
        Console.WriteLine(str);
    }

    public void BecameOlder()
    {
        this.Age++;
    }
}