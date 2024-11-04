int choise;
int i =-1;
List <Student> students = new List<Student>();

do
{
    Console.WriteLine("\nВыберите действие:\n1 - Создать нового студента;\n2 - Выбрать существующего студента;\n3 - Вывести информацию о выбранном студенте;\n" +
        "4 - Сделать выбранного студента старше;\n5 - Изменить имя выбранного студента;\n6 - Изменить возраст выбранного студента;\n7 - Выход из программы");
    string? str = Console.ReadLine();
    int.TryParse(str, out choise);
    switch (choise)
    {
        case 1:
            Console.Clear();
            string name = CheckInput.EnterName("Введите имя студента: ");
            int? age = CheckInput.EnterAge("Введите возраст студента: ");
            AddStudent(name, age);
            break;
        case 2:
            Console.Clear();
            if(students.Count == 0)
            {
                Console.WriteLine("Список пуст");
            }
            else
            {
                Console.WriteLine("Список студентов:\n");
                for (int j = 0; j < students.Count; j++)
                {
                    Console.WriteLine($"{j + 1}. {students[j].WriteInfo()}");
                }
                bool res = false;
                do
                {
                    Console.WriteLine("\nВведите номер студента, которого хотите выбрать");
                    res = int.TryParse(Console.ReadLine(), out i);
                }
                while (i <= 0 || i > students.Count || res == false);
                Console.WriteLine($"\nВыбран студент с номером {i}");
                i--;
                
            }
            break;
        case 3:
            Console.Clear();
            if(i != -1)
            {
                Console.WriteLine(students[i].WriteInfo());
            }
            else
            {
                Console.WriteLine("Студент не выбран");
            }
            break;
        case 4:
            Console.Clear();
            if (i != -1)
            {
                students[i].BecameOlder();
                Console.WriteLine("Студент стaл старше на один год!");
                Console.WriteLine($"Было: {students[i].Age - 1}");
                Console.WriteLine($"Стало: {students[i].Age}");
            }
            break;
        case 5:
            Console.Clear();
            if (i != -1)
            {
                string new_name;
                do
                {
                    Console.WriteLine("Введите новое имя для студента:");
                    new_name = Console.ReadLine();
                }
                while (String.IsNullOrEmpty(new_name));
                Console.WriteLine($"Было: {students[i].WriteInfo()}");
                students[i].Name = new_name;
                Console.WriteLine($"Стало: {students[i].WriteInfo()}");

                Console.WriteLine($"Имя успешно изменено на {new_name}");
            }
            else
            {
                Console.WriteLine("Студент не выбран");
            }
            break;
        case 6:
            Console.Clear();
            if(i != -1)
            {
                bool res = false;
                int new_age = -1;
                do
                {
                    Console.WriteLine("Введите новый возраст для студента:");
                    res = int.TryParse(Console.ReadLine(), out new_age);
                }
                while (!res);
                Console.WriteLine($"Было: {students[i].WriteInfo()}");
                students[i].Age = new_age;
                Console.WriteLine($"Стало: {students[i].WriteInfo()}");
                Console.WriteLine($"Возраст успешно изменен на {new_age}");
            }
            else
            {
                Console.WriteLine("Студент не выбран");
            }
            break;
        case 7:
            Console.Clear();
            Console.WriteLine("Выход из программы");
            break;
    }
}
while(choise != 7);

void AddStudent(string name, int? age)
{
    if (age.HasValue)
    {
        Student student = new Student(name, age.Value);
        students.Add(student);
    }
    else
    {
        Student student = new Student(name);
        students.Add(student);
    }
    Console.WriteLine("Новый студент добавлен");
}

public class CheckInput
{
    public static string EnterName(string str)
    {
        string? name;
        do
        {
            Console.WriteLine(str);
            name = Console.ReadLine();
        }
        while (String.IsNullOrEmpty(name));
        return name;
    }

    public static int? EnterAge(string str)
    {
        string? input;
        int number;
        do
        {
            Console.WriteLine(str);
            input = Console.ReadLine();
        }
        while (int.TryParse(input, out number) == false);
        return number;
    }
}



public class Student
{
    private string? _name;
    public int? age;

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

    public string WriteInfo()
    {
        string str = "";
        if (!String.IsNullOrEmpty(this._name))
        {
            str = $"Имя студента - {this._name}";
        }
        if (this.age.HasValue)
        {
            str += $", возраст студента - {this.age}";
        }
        return str;
    }

    public void BecameOlder()
    {
        this.age++;
    }
}