Student Dasha = new Student("Dasha", 21);

DiffrenceBetweenPrivateAndPublic();
DifferenceBetweenByValueAndByLink();
InfoAboutStudentWithGameAndSubject();


void DiffrenceBetweenPrivateAndPublic()
{
    Dasha.WriteInfo();
    //student._name = "Masha"; //выдаст ошибку, так как поле с модификатором private
    Dasha.age = 16; //доступ разрешен так как поле с модификатором public
    Dasha.WriteInfo();
}

void DifferenceBetweenByValueAndByLink()
{
    Console.WriteLine("\nПередача параметра по значению\nДо:");
    Dasha.WriteInfo();
    PassingByValue(Dasha);
    Console.WriteLine("После:");
    Dasha.WriteInfo();
    Console.WriteLine("\nПередача параметра по ссылке\nДо:");
    Dasha.WriteInfo();
    PassingByLink(ref Dasha);
    Console.WriteLine("После:");
    Dasha.WriteInfo();
}

void PassingByValue(Student student)
{
    student = new Student("Masha", 23);
}

void PassingByLink(ref Student student)
{
    student = new Student("Masha", 23);
}

void InfoAboutStudentWithGameAndSubject()
{
    Game game = new Game("Герои мечаи магии 5", "Стратегия", 2009, true);
    Subject subject = new Subject("Информатика и программирование", "Гольчевский Ю.В.", 5);
    Student Igor = new Student("Igor", 21, game, subject);
    Igor.WriteInfo();
}


public class Student
{
    private string? _name;
    public int? age;
    public Game favGame;
    public Subject favSubject;

    public string Name
    {
        get
        {
            if (String.IsNullOrEmpty(_name))
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

    public Student(string name, int age, Game favGame, Subject favSubject)
    {
        this._name = name;
        this.age = age;
        this.favGame = favGame;
        this.favSubject = favSubject;
    }

    public void WriteInfo()
    {
        string str = "Информация о студенте:";
        if (!String.IsNullOrEmpty(_name))
        {
            str += $"\nИмя студента - {_name}";
        }
        if (age.HasValue)
        {
            str += $"\nВозраст студента - {age}";
        }
        if (favGame != null)
        {
            str += $"\n\nИнформация о любимой игре студента: {favGame.GetInfoAboutGame()}";
        }
        if (favSubject != null)
        {
            str += $"\n\nИнформация о любимом предмете студента: {favSubject.GetInfoAboutSubject()}";
        }
        str += "\n";
        Console.WriteLine(str);
    }

    public void BecameOlder()
    {
        this.age++;
    }
}

public class Game
{
    public string name;
    public string genre;
    public int yearOfRelease;
    public bool isMultiPlayer;

    public Game(string name, string genre, int yearOfRelease, bool isMultiPlayer)
    {
        this.name = name;
        this.genre = genre;
        this.yearOfRelease = yearOfRelease;
        this.isMultiPlayer = isMultiPlayer;
    }

    public string GetInfoAboutGame()
    {
        string str = "";
        str += (String.IsNullOrEmpty(name) ? "" : $"\nНазвание игры - {name}");
        str += (String.IsNullOrEmpty(genre) ? "" : $"\nЖанр игры - {genre}");
        str += (yearOfRelease == null ? "" : $"\nГод выхода - {yearOfRelease}");
        str += $"\nМультиплеер - {(isMultiPlayer ? "да" : "нет")}";
        return str;
    }
}

public class Subject
{
    public string name;
    public string teacher;
    private int grade;

    public Subject(string name, string teacher, int grade)
    {
        this.name = name;
        this.teacher = teacher;
        this.grade = grade;
    }

    public string GetInfoAboutSubject()
    {
        string str = "";
        str += (String.IsNullOrEmpty(name) ? "" : $"\nНазвание предмета - {name}");
        str += (String.IsNullOrEmpty(teacher) ? "" : $"\nПреподаватель - {teacher}");
        str += (grade == null) ? "" : $"\nОценка по предмету - {grade}";
        return str;
    }
}