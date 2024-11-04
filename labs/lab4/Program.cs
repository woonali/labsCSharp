DifferenceBetweenHiddingAndOverride();//разница между скрытие и переопределением
OverrideToString();//демонстрация переопределения ToString()

void OverrideToString()
{
    Student student = new Student();
    Console.WriteLine(student.ToString());
}

void DifferenceBetweenHiddingAndOverride()
{
    Student alice = new ITStudent()
    {
        Name = "Алиса",
        Age = 23,
        university = "ГУАП",
        favoriteProgrammLang = "Java",
        isWorking = true,
        course = 2
    };
    alice.WriteInfo();//переопределенный из класса ITStudent, хотя объект класса Student
    alice.BecameOlder();//скрытый, выполняется метод из Student

    ITStudent bob = new ITStudent()
    {
        Name = "Боб",
        Age = 20,
        course = 2
    };
    bob.BecameOlder();//выполняется скрытый метод, так как объект класса ITStudent
}

public abstract class Person
{
    public abstract string Name { get; set; }
    abstract public int Age { get; set; }
    public bool isMorningPerson;

    public abstract void BecameOlder();
}

public class Student : Person
{
    private string name;
    private int age;
    public string university;
    public bool IsGetScholarship;
    public override string Name { get; set; }
    public override int Age { get; set; }

    public override void BecameOlder()
    {
        this.Age++;
        Console.WriteLine($"Изменено: возраст - {this.Age}");
    }
    public virtual void WriteInfo()
    {
        string str = "";
        str = $"Имя студента - {this.name}";
        str += $", возраст студента - {this.age}";
        str += $", университет - {this.university}";
        Console.WriteLine(str);
    }
    public override string? ToString()
    {
        return "Метод toString() переопределен XD";
    }
}

public class ITStudent : Student
{
    public string favoriteProgrammLang;
    public bool isWorking;
    public short course;

    public override void WriteInfo()
    {
        string str = "";
        str = $"Имя студента - {base.Name}";
        str += $", возраст студента - {base.Age}";
        str += $", любимый ЯП - {this.favoriteProgrammLang}";
        Console.WriteLine(str);
    }

    public new void BecameOlder()
    {
        this.Age++;
        this.course++;
        Console.WriteLine($"Изменено: возраст - {this.Age}, курс - {this.course}");
    }
}