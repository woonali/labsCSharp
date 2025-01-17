using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using System.Globalization;
using System.Xml;

namespace lab9
{
    public partial class Form1 : Form
    {
        public OpenFileDialog openFileDialog;
        public string? fileType;
        public string? fileName;
        public Form1()
        {
            InitializeComponent();

            listView1.Columns[0].Width = listView1.Width / 3;
            listView1.Columns[1].Width = listView1.Width / 3;
            listView1.Columns[2].Width = listView1.Width / 3;

            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "Все файлы (*.*)|*.*|Файл JSON (*.json)|*.json|Файл XML (*.xml)|*.xml|Файл CSV (*.csv)|*.csv";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
        }

        private void AddStudentAtListView(Student student)
        {
            ListViewItem item = new ListViewItem(student.recordBook);
            item.SubItems.Add(student.fullName);
            item.SubItems.Add(student.specification);

            listView1.Items.Add(item);
        }

        private List<Student> GetListOfStudentsFromListView()
        {
            List<Student> students = new List<Student>();

            foreach(ListViewItem item in listView1.Items)
            {
                string recordBook = item.Text;
                string fullName = item.SubItems[1].Text;
                string specification = item.SubItems[2].Text;

                Student student = new Student(recordBook, fullName, specification);
                students.Add(student);
            }

            return students;
        }

        private void button1_Click(object sender, EventArgs e) //кнопка добавления записи
        {
            if (maskedTextBox1.Text == string.Empty || textBox1.Text == string.Empty || textBox2.Text == String.Empty)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            string recordBook = maskedTextBox1.Text;
            string fullName = textBox1.Text;
            string specification = textBox2.Text;

            Student newStudent = new Student(recordBook, fullName, specification);
            AddStudentAtListView(newStudent);

            maskedTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e) //кнопка удаления записи
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления");
            }
        }

        private void button3_Click(object sender, EventArgs e) //кнопка выбора файла
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileType = Path.GetExtension(openFileDialog.FileName);
                if (fileType != ".json" && fileType != ".xml" && fileType != ".csv")
                {
                    MessageBox.Show("Выбранный тип файла не поддерживается. \nВыберите один из следующих - json, xml, csv");
                    return;
                }
                textBox3.Text = openFileDialog.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e) //кнопка чтения из файла
        {
            if (fileName == String.Empty)
            {
                MessageBox.Show("Файл не выбран!");
                return;
            }
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Файл не найден!");
                return;
            }

            listView1.Items.Clear();
            switch (fileType)
            {
                case ".json":
                    ImportFromJson();
                    break;
                case ".xml":
                    ImportFromXml();
                    break;
                case ".csv":
                    ImportFromCsv();
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e) // кнопка сохранения в файл
        {
            if (textBox3.Text == String.Empty)
            {
                MessageBox.Show("Файл не выбран!");
                return;
            }
            if (!File.Exists(textBox3.Text))
            {
                MessageBox.Show("Файл не найден!");
                return;
            }

            List<Student> students = GetListOfStudentsFromListView();

            switch (fileType)
            {
                case ".json":
                    ExportToJson(students);
                    break;
                case ".xml":
                    ExportToXml(students);
                    break;
                case ".csv":
                    ExportToCsv(students);
                    break;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            fileName = textBox3.Text;
        }

        private void ImportFromJson()
        {
            try
            {
                string jsonText = File.ReadAllText(fileName);
                List<Student>? students = JsonConvert.DeserializeObject<List<Student>>(jsonText);
                if(students != null && students.Count > 0)
                {
                    foreach (Student student in students)
                    {
                        AddStudentAtListView(student);
                    }
                    MessageBox.Show("Данные успешно импортированы!");
                }
                else
                {
                    MessageBox.Show("Файл пуст!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось импортировать данные");
            }
        }

        private void ImportFromXml()
        {
            XmlReader? reader = null;
            try
            {
                reader = XmlReader.Create(fileName);
                reader.MoveToContent();
                if(reader.NodeType == XmlNodeType.Element && reader.Name == "students")
                {
                    while (reader.Read())
                    {
                        Student? student = null;
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "student")
                            {
                                student = new Student();
                                while (reader.Read())
                                {
                                    if(reader.NodeType == XmlNodeType.Element)
                                    {
                                        switch (reader.Name)
                                        {
                                            case "recordBook":
                                                if (student != null)
                                                {
                                                    student.recordBook = reader.ReadElementContentAsString();
                                                }                                                
                                                break;
                                            case "fullName":
                                                if (student != null)
                                                {
                                                    student.fullName = reader.ReadElementContentAsString();
                                                }
                                                break;
                                            case "specification":
                                                if(student != null)
                                                {
                                                    student.specification = reader.ReadElementContentAsString();                                                    
                                                }                                                
                                                break;
                                        }
                                    }
                                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "student")
                                    {
                                        if (student != null)
                                        {
                                            AddStudentAtListView(student);
                                        }
                                        break;
                                    }
                                }                        
                            }
                        }
                    }
                }
                MessageBox.Show("Данные успешно импортированы!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось импортировать данные");
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void ImportFromCsv()
        {
            StreamReader? reader = null;
            try
            {
                reader = new StreamReader(fileName);
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();
                    string?[] values = line.Split(", ");
                    if (values.Length == 3)
                    {
                        AddStudentAtListView(new Student(values[0], values[1], values[2]));
                    }                    
                }
                MessageBox.Show("Данные успешно импортированы!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось импортировать данные");
            }
            finally
            {
                if( reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void ExportToJson(List<Student> students)
        {
            try
            {
                string data = JsonConvert.SerializeObject(students, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(fileName, data);

                MessageBox.Show($"Данные успешно экспортированы в файл {fileName}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось экспортировать данные");
            }
        }

        private void ExportToXml(List<Student> students)
        {
            XmlWriter? writer = null;
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                writer = XmlWriter.Create(fileName, settings);
                writer.WriteStartDocument();
                writer.WriteStartElement("students");

                foreach (Student student in students)
                {
                    writer.WriteStartElement("student");

                    writer.WriteElementString("recordBook", student.recordBook);
                    writer.WriteElementString("fullName", student.fullName);
                    writer.WriteElementString("specification", student.specification);

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
                MessageBox.Show($"Данные успешно экспортированы в файл {fileName}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось экспортировать данные");
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }                
            }
        }

        private void ExportToCsv(List<Student> students)
        {
            StreamWriter? writer = null;
            try
            {
                writer = new StreamWriter(fileName);
                var config = new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ", " };
                CsvWriter csvWriter = new CsvWriter(writer, config);
                csvWriter.WriteRecords(students);
                MessageBox.Show($"Данные успешно экспортированы в файл {fileName}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось экспортировать данные");
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }
    }

    public class Student
    {
        public string? recordBook { get; set;}
        public string? fullName { get; set; }
        public string? specification { get; set; }

        public Student() { }
        public Student(string recordBook, string fullName, string specification)
        {
            this.recordBook = recordBook;
            this.fullName = fullName;
            this.specification = specification;
        }
    }
}
