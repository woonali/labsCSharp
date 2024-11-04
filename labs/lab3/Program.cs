//конструктор с значениями по умолчанию
Student pasha = new Student("Паша", 17);

//гибкий конструктор
Student alice = new Student();

//инициализатор
Student bob = new Student() {name = "Боб", age = 25 };

Student.IsAdult(bob);
Student.IsAdult(pasha);

Student.Adult = 26;
Student.IsAdult(bob);

CompareStudent.CompareByAge(alice, bob);

public class Student
{
    public string name;
    public int age;
    private static int adult;

    public static int Adult
    {
        get { return adult; }
        set { adult = value; }        
    }

    public Student()
    {
        name = "Alice";
        age = 30;
    }

    public Student(string _name, int age)
    {
        this.name = _name;
        this.age = age;
    }

    static Student()
    {
        adult = 18;
    }


    public string WriteInfo()
    {
        string str = "";
        str = $"Имя студента - {this.name}";
        str += $", возраст студента - {this.age}";
        return str;
    }

    public void BecameOlder()
    {
        this.age++;
    }

    public static void IsAdult(Student student)
    {
        if(student.age >= adult)
        {
            Console.WriteLine($"{student.name} уже взрослый!");
        }
        else
        {
            Console.WriteLine($"{student.name} маленький ещё :(");
        }
    }
}

static class CompareStudent
{
    public static void CompareByAge(Student st1, Student st2)
    {
        if(st1.age < st2.age)
        {
            Console.WriteLine($"{st2.name} старше {st1.name} на {st2.age - st1.age} лет");
        }
        if(st1.age == st2.age)
        {
            Console.WriteLine($"{st2.name} и {st1.name} одного возраста");
        }
        if (st1.age > st2.age)
        {
            Console.WriteLine($"{st1.name} старше {st2.name} на {st1.age - st2.age} лет");
        }
    }
}