using System.Security.Policy;
using System.Xml.Linq;

namespace lab7
{
    public partial class Form1 : Form
    {
        private string pathToXml = "D:\\учёба какая-то\\3 курс\\С#\\labs\\lab7\\students.xml";
        private List<Department> listDepartment = new List<Department>();
        private List<Specification> listSpecification = new List<Specification>();

        public Form1()
        {
            InitializeComponent();
        }
        private void InitDepartment()
        {
            List<Department> departments = new List<Department> {
                new Department(0, "Институт точных наук и информационных технологий"),
                new Department(1, "Институт гуманитраных наук"),
                new Department(2, "Медицинский институт"),
                new Department(3, "Институт социальных технологий"),
                new Department(4, "Институт естественных наук")
            };

            listDepartment = departments;
            comboBox1.DataSource = listDepartment;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = -1;
        }
        private void InitSpecification()
        {
            List<Specification> specifications = new List<Specification> {
                new Specification(0, "Прикладная информатика", 0),//итниит
                new Specification(1, "Информационная безопасность", 0),
                new Specification(2, "Математика и компьютерные науки", 0),
                new Specification(3, "Журналистика", 1),//игн
                new Specification(4, "Филология", 1),
                new Specification(5, "Лингвистика", 1),
                new Specification(6, "Педиатрия", 2),//мед
                new Specification(7, "Лечеюное дело", 2),
                new Specification(8, "Общественное здравоохранение", 2),
                new Specification(9, "Физическая культура", 3),//исн
                new Specification(10, "Психология", 3),
                new Specification(11, "Социальная работа", 3),
                new Specification(12, "Геология", 4),//иен
                new Specification(13, "Биология", 4),
                new Specification(14, "Химия", 4)
            };

            comboBox2.DataSource = listSpecification;
            listSpecification = specifications;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitDepartment();
            InitSpecification();
            ReadStudents();
        }
        private void ReadStudents()
        {
            dataGridView1.Rows.Clear();
            List<Student> listOfStudents = new List<Student>();

            XDocument doc = XDocument.Load(pathToXml);
            XElement? students = doc.Element("students");
            if (students != null)
            {
                foreach (XElement student in students.Elements("student"))
                {
                    XAttribute? recordBook = student.Attribute("recordBook");
                    XElement? fullName = student.Element("fullName");
                    XElement? departmentId = student.Element("departmentId");
                    XElement? specificationId = student.Element("specificationId");
                    XElement? dateOfAdmission = student.Element("dateOfAdmission");
                    XElement? group = student.Element("group");

                    if (recordBook != null && fullName != null && departmentId != null && specificationId != null
                        && dateOfAdmission != null && group != null)
                    {
                        Department? department = (Department?)comboBox1.Items[int.Parse(departmentId.Value)];
                        Specification specification = listSpecification[int.Parse(specificationId.Value)];

                        listOfStudents.Add(new Student(recordBook.Value, fullName.Value, department, specification,
                            dateOfAdmission.Value, group.Value));
                    }
                }
            }

            for (int i = 0; i < listOfStudents.Count; i++)
            {
                Student student = listOfStudents[i];
                if (student.department != null && student.specification != null)
                {
                    dataGridView1.Rows.Add(student.recordBook, student.fullName, student.department.Name,
                    student.specification.Name, student.dateOfAdmission, student.group);
                }
            }
        }

        private void AddStudent()
        {
            if (maskedTextBox1.Text == null || textBox2.Text == null && comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1
                || dateTimePicker1.Text == null || maskedTextBox1 == null)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            bool flag = CheckValidating();

            if (flag)
            {
                Student newStudent = new Student(maskedTextBox1.Text, textBox2.Text, (Department?)comboBox1.SelectedItem,
                (Specification?)comboBox2.SelectedItem, dateTimePicker1.Value.Date.ToString("dd.MM.yyyy"), maskedTextBox2.Text);

                XDocument doc = XDocument.Load(pathToXml);
                XElement? students = doc.Element("students");

                if (students != null && newStudent.recordBook != null && newStudent.fullName != null && newStudent.department != null
                    && newStudent.specification != null && newStudent.dateOfAdmission != null && newStudent.group != null)
                {
                    students.Add(new XElement("student",
                        new XAttribute("recordBook", newStudent.recordBook),
                        new XElement("fullName", newStudent.fullName),
                        new XElement("departmentId", newStudent.department.Id),
                        new XElement("specificationId", newStudent.specification.Id),
                        new XElement("dateOfAdmission", newStudent.dateOfAdmission),
                        new XElement("group", newStudent.group)
                    ));
                    doc.Save(pathToXml);
                }

                ClearInfo();
                ReadStudents();
            }
        }

        private void UpdateStudent()
        {
            XDocument doc = XDocument.Load(pathToXml);
            XElement? students = doc.Element("students");

            string recordBookValue = (string)dataGridView1.CurrentRow.Cells[0].Value;
            XElement? selectedStudent = null;

            if (students != null)
            {
                selectedStudent = students.Elements("student")
                .FirstOrDefault(student =>
                    student.Attribute("recordBook")?.Value == recordBookValue);
            }

            if (selectedStudent != null && selectedStudent.Attribute("recordBook") != null)
            {
                var recordBook = selectedStudent.Attribute("recordBook");
                if (recordBook != null)
                {
                    recordBook.Value = maskedTextBox1.Text;
                }

                var fullName = selectedStudent.Element("fullName");
                if (fullName != null)
                {
                    fullName.Value = textBox2.Text;
                }

                var departmetnId = selectedStudent.Element("departmentId");
                if (departmetnId != null)
                {
                    departmetnId.Value = ((Department?)comboBox1.SelectedItem)?.Id.ToString() ?? string.Empty;
                }

                var specificationId = selectedStudent.Element("specificationId");
                if (specificationId != null)
                {
                    specificationId.Value = ((Specification?)comboBox2.SelectedItem)?.Id.ToString() ?? string.Empty;
                }

                var date = selectedStudent.Element("dateOfAdmission");
                if (date != null)
                {
                    date.Value = dateTimePicker1.Value.ToString("dd.MM.yyyy");
                }

                var group = selectedStudent.Element("group");
                if (group != null)
                {
                    group.Value = maskedTextBox2.Text;
                }
            }

            doc.Save(pathToXml);
            ReadStudents();
            ClearInfo();
        }

        private void DeleteStudent()
        {
            XDocument doc = XDocument.Load(pathToXml);
            XElement? students = doc.Element("students");

            string recordBookValue = (string)dataGridView1.CurrentRow.Cells[0].Value;

            XElement? selectedStudent = null;

            if (students != null)
            {
                selectedStudent = students.Elements("student")
                .FirstOrDefault(student =>
                    student.Attribute("recordBook")?.Value == recordBookValue);
            }

            if (selectedStudent != null)
            {
                selectedStudent.Remove();
                doc.Save(pathToXml);
            }
            ReadStudents();
            ClearInfo();
        }

        private bool CheckValidating()
        {
            string checkRecordBook = maskedTextBox1.Text;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cellRecordBook = row.Cells[0].Value.ToString();
                if (cellRecordBook != null)
                {
                    if (cellRecordBook.ToString().Equals(checkRecordBook))
                    {
                        MessageBox.Show("Студент с таким номером студенческого билета уже существует! Введите новое значение.");
                        return false;
                    }
                }
            }
            return true;
        }

        private void ClearInfo()
        {
            maskedTextBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Text = DateTime.Now.ToString();
            maskedTextBox2.Text = string.Empty;
        }

        private void SelectRow()
        {
            maskedTextBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            var dataSource1 = comboBox1.DataSource as List<Department>;
            if (dataSource1 != null)
            {
                var Item1 = dataSource1.FirstOrDefault(item => item.Name == dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                comboBox1.SelectedItem = Item1;
            }
            NewDataSourceComboBox2();
            var dataSource2 = comboBox2.DataSource as List<Specification>;
            if (dataSource2 != null)
            {
                var Item2 = dataSource2.FirstOrDefault(item => item.Name == dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                comboBox2.SelectedItem = Item2;
            }
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            maskedTextBox2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void NewDataSourceComboBox2()
        {
            comboBox2.DataSource = null;
            List<Specification> newDS = new List<Specification>();
            foreach (Specification specification in listSpecification)
            {
                if (specification.IdDepartment == comboBox1.SelectedIndex)
                {
                    newDS.Add(specification);
                }
            }
            comboBox2.DataSource = newDS;
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateStudent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteStudent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            NewDataSourceComboBox2();
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.SelectAll();
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.SelectAll();
        }
    }


    public class Student
    {
        public string? recordBook;
        public string? fullName;
        public Department? department;
        public Specification? specification;
        public string? dateOfAdmission;
        public string? group;

        public Student(string? recordBook, string? fullName, Department? department, Specification? specification,
            string? dateOfAdmission, string? group)
        {
            this.recordBook = recordBook;
            this.fullName = fullName;
            this.department = department;
            this.specification = specification;
            this.dateOfAdmission = dateOfAdmission;
            this.group = group;
        }
    }
    public class Department
    {
        private int id;
        private string? name;

        public int Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }

        public Department(int id, string? name)
        {
            Id = id;
            Name = name;
        }
    }
    public class Specification
    {
        private int id;
        private string? name;
        private int idDepartment;

        public int Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public int IdDepartment { get => idDepartment; set => idDepartment = value; }

        public Specification(int id, string? name, int idDepartment)
        {
            Id = id;
            Name = name;
            IdDepartment = idDepartment;
        }
    }
}
