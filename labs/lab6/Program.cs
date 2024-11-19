class Programm
{
    static void Main(string[] args)
    {
        try
        {
            Student student = new Student("Alla", 18, "SGU", true);
            student.Name = ""; //вызов исключения при пустом имени
            student.Age = -16; //вызов исключения при отрицательном возрасте
            student.Age = 151; // вызов исключения при слишком большом возрасте
        }
        catch (Exception ex)
        {
            Console.WriteLine("Что-то пошло не так\nТрассировка стека: " + ex.StackTrace);
        }
        finally
        {
            Console.WriteLine("Выполнение программного кода завершено!");
        }
    }

    public class Student
    {
        private string name;
        private int age;
        public string university;
        public bool IsGetScholarship;//стипендия
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                try
                {
                    if (value == null || value == "")
                    {
                        throw new ArgumentNullException();  //использование throw
                    }
                    name = value;
                }
                catch (ArgumentNullException ex) 
                {
                    Console.WriteLine("Имя не может быть пустым");
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else if (value > 150)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        age = value;
                    }

                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Возраст не задан\nСообщение об ошибке: " + ex.Message);
                }
                catch (ArgumentOutOfRangeException ex) when(value < 0)  //использование when
                {
                    Console.WriteLine("Возраст не может быть меньше 0");
                }
                catch (ArgumentOutOfRangeException ex) when (value > 150)
                {
                    Console.WriteLine("Возраст не может быть больше 150");
                }
            }
        }

        public Student(string name, int age, string university, bool isGetScholarship)
        {
            Name = name;
            Age = age;
            this.university = university;
            IsGetScholarship = isGetScholarship;
        }

        public void BecameOlder()
        {
            this.Age++;
            Console.WriteLine($"Изменено: возраст - {this.Age}");
        }
    }
}