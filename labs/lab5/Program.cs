class Program
{
    static void Main(string[] args)
    {
        Subject subject1 = new Subject("Физкультура", "Григорьевич", 4);
        Student student1 = new Student("Алекс", "Крыжовников", 17, subject1);
        //ShowClone(student1);
        //ShowCompareTo();
        ShowITStudent();
    }


    static void ShowClone(Student student1)
    {
        Console.WriteLine("\nДо клонирования\n");
        Student student2 = student1;
        student2.name = "Паша";
        student1.WriteInfo();
        student2.WriteInfo();

        Console.WriteLine("\nПосле клонирования\n");
        student2 = (Student)student1.Clone();
        student2.age = 1;
        student2.surname = "Пышкин";
        student1.WriteInfo();
        student2.WriteInfo();
    }

    static void ShowCompareTo()
    {
        Student st1 = new Student("Maria", "Radrigo", 19);
        Student st2 = new Student("Igor", "Latkin", 27);

        int res = st1.CompareTo(st2);
        if (res > 0)
        {
            Console.WriteLine($"{st1.FullName} старше, чем " + (st2 == null ? "второй студент" : st2.FullName));//использование свойства FullName
        }
        else if (res < 0)
        {
            Console.WriteLine($"{st1.FullName} моложе, чем {st2.FullName}");
        }
        else
        {
            Console.WriteLine($"{st1.FullName} и {st2.FullName} одного возраста");
        }
    }

    static void ShowITStudent()
    {
        ITStudent itstudent = new ITStudent()
        {
            name = "Dima",
            surname = "Pozov",
            Speciality = "data base",
            age = 19,
            yearOfLicense = 2019,
            experience = 2
        };

        
        ISpecialist specialist = itstudent;
        specialist.WriteInfo();
        specialist.UpdateExperience();
        specialist.WriteInfo();

        specialist.IsCertidied();
        itstudent.yearOfLicense = 2024;
        specialist.IsCertidied();

    }

    interface IPerson
    {
        string FullName { get; }

        void WriteInfo();
        void IsAdult();
    }

    interface ISpecialist : IPerson
    {
        string Speciality { get; set; }

        void UpdateExperience();
        void IsCertidied();
    }

    public class Student : IPerson, ICloneable, IComparable<Student>
    {
        public string name;
        public string surname;
        public int age;
        public Subject? favSubject;

        public string FullName//неявное приминение интерфейсов
        {
            get { return name + " " + surname; }
        }

        public Student(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public Student(string name, string surname, int age, Subject favSubject)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.favSubject = favSubject;
        }

        public void WriteInfo()
        {
            string str = "";
            str = $"Полное имя студента - {FullName}";
            str += $", возраст студента - {this.age}";
            str += (favSubject == null ? "" : favSubject.GetInfoAboutSubject());
            Console.WriteLine(str);
        }

        public void IsAdult()
        {
            if (this.age >= 18)
            {
                Console.WriteLine("Студент совершеннолетний");
            }
            else
            {
                Console.WriteLine("Студент ещё маленький");
            }
        }

        public object Clone()
        {
            return new Student(this.name, this.surname, this.age, new Subject(this.favSubject.name, this.favSubject.teacher, this.favSubject.grade));
        }

        public int CompareTo(Student? other)
        {
            if (other == null) return 1;
            return this.age.CompareTo(other.age);
        }
    }

    public class ITStudent : ISpecialist
    {
        public string name;
        public string surname;
        private string speciality;
        public int age;//возраст
        public int yearOfLicense;//год получения лицензии
        public int experience;//опыт работы

        public string FullName
        {
            get { return name + " " + surname; }
        }
        public string Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }

        void IPerson.WriteInfo()//явная реализация интерфейса
        {
            string str = "";
            str = $"Полное имя студента - {FullName}";
            str += $", возраст студента - {this.age}";
            str += $"\nСпециальность - {Speciality}";
            str += $"\nГод получения лицензии - {this.yearOfLicense}";
            str += $"\nОпыт работы - {this.experience}";
            Console.WriteLine(str);
        }
        void IPerson.IsAdult()
        {
            if (this.age >= 18)
            {
                Console.WriteLine("Студент совершеннолетний");
            }
            else
            {
                Console.WriteLine("Студент ещё маленький");
            }
        }
        void ISpecialist.UpdateExperience()
        {
            experience++;
        }
        void ISpecialist.IsCertidied()
        {
            if (DateTime.Now.Year - yearOfLicense < 2)
            {
                Console.WriteLine("Сертифекат специалиста ещё действителен");
            }
            else
            {
                Console.WriteLine("Сертификат специалиста просрочен");
            }
        }
    }

    public class Subject
    {
        public string name;
        public string teacher;
        public int grade;

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
}