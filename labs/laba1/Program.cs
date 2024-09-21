Student Anna = new("Anna");
Student Nikita = new("Nikita", 15);
Nikita.WriteInfo();
Nikita.BecameOlder();
Nikita.BecameOlder();
Nikita.BecameOlder();
Nikita.BecameOlder();
Nikita.WriteInfo();
Anna.WriteInfo();

Student st = new("123");
st.WriteInfo();
st.Name = "Tratatat";
st.WriteInfo();

public class Student
{
    private string? _name;
    public int? age;

    public string Name
    {
        get
        {
            if (string.IsNullOrEmpty(_name))
            {
                return "";
            }
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    public int Age
    {
        get
        {
            if (age.HasValue)
            {
                return (int)age;
            }
            return int.Parse("");
            
        }
        set
        {
            age = value;
        }
    }

    public Student(string _name, int age)
    {
        this._name = _name;
        this.age = age;
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
        if (this.age.HasValue)
        {
            str += $", возраст студента - {this.age}";
        }
        Console.WriteLine(str);
    }

    public void BecameOlder()
    {
        this.age++;
    }
}