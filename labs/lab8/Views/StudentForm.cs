using lab8.Models;
using lab8.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8.Views
{
    public partial class StudentForm : Form, IStusentView
    {
        public int recordBook
        {
            get { return int.Parse(maskedTextBox3.Text); }
            set { maskedTextBox3.Text = value.ToString(); }
        }
        public string nameStudent
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string department
        {
            get { return comboBox3.Text; }
            set
            {
                comboBox3.SelectedIndex = -1;
                foreach (Department department in listDepartment)
                {
                    if (department.Name == value)
                    {
                        comboBox3.SelectedItem = value;
                    }
                }
            }
        }
        public string specification
        {
            get { return comboBox4.Text; }
            set
            {
                comboBox4.SelectedIndex = -1;
                foreach (Specification specification in listSpecification)
                {
                    if (specification.Name == value)
                    {
                        comboBox4.SelectedItem = value;
                    }
                }
            }
        }
        public DateTime dateOfAdmission
        {
            get { return dateTimePicker2.Value.Date; }
            set { dateTimePicker2.Value = value; }
        }
        public string group
        {
            get { return maskedTextBox4.Text; }
            set { maskedTextBox4.Text = value; }
        }
        public int oldRecordBook
        {
            get
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    return int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    return -1;
                }
            }
        }

        public event EventHandler fillTable;
        public event EventHandler addStudent;
        public event EventHandler updateStudent;
        public event EventHandler deleteStudent;

        private DataView dataView;
        public void fillTableOfStudents(DataTable data)
        {
            dataView = new DataView(data);
            dataGridView1.DataSource = dataView;
            dataGridView2.DataSource = data;
        }


        private List<Department> listDepartment = new List<Department>();
        private List<Specification> listSpecification = new List<Specification>();
        private string filter;

        public StudentForm()
        {
            InitializeComponent();
            InitDepartment();
            InitSpecification();

            var model = new StudentModel();
            var presenter = new StudentPresenter(this, model);

            this.Load += (s, e) => fillTable?.Invoke(s, e);

            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += TabControl1_DrawItem;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
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
            comboBox1.DataSource = new List<Department>(listDepartment);
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = -1;

            comboBox3.DataSource = new List<Department>(listDepartment);
            comboBox3.ValueMember = "Id";
            comboBox3.DisplayMember = "Name";
            comboBox3.SelectedIndex = -1;
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
                new Specification(7, "Лечебное дело", 2),
                new Specification(8, "Общественное здравоохранение", 2),
                new Specification(9, "Физическая культура", 3),//исн
                new Specification(10, "Психология", 3),
                new Specification(11, "Социальная работа", 3),
                new Specification(12, "Геология", 4),//иен
                new Specification(13, "Биология", 4),
                new Specification(14, "Химия", 4)
            };

            comboBox2.DataSource = listSpecification;
            comboBox4.DataSource = listSpecification;
            listSpecification = specifications;
        }

        private void NewDataSourceComboBox2()
        {
            comboBox2.DataSource = null;
            List<Specification> newDS = new List<Specification>();
            foreach (Specification specification in listSpecification)
            {
                if (specification.IdDepartment == (comboBox1.SelectedIndex != -1 ? comboBox1.SelectedIndex : -1))
                {
                    newDS.Add(specification);
                }
            }
            comboBox2.DataSource = newDS;
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "Name";
        }

        private void NewDataSourceComboBox4()
        {
            comboBox4.DataSource = null;
            List<Specification> newDS = new List<Specification>();
            foreach (Specification specification in listSpecification)
            {
                if (specification.IdDepartment == (comboBox3.SelectedIndex != -1 ? comboBox3.SelectedIndex : -1))
                {
                    newDS.Add(specification);
                }
            }
            comboBox4.DataSource = newDS;
            comboBox4.ValueMember = "Id";
            comboBox4.DisplayMember = "Name";
        }

        private void SelectRowForTable2()
        {
            maskedTextBox3.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            var dataSource1 = comboBox3.DataSource as List<Department>;
            if (dataSource1 != null)
            {
                var Item1 = dataSource1.FirstOrDefault(item => item.Name == dataGridView2.SelectedRows[0].Cells[2].Value.ToString());
                comboBox3.SelectedItem = Item1;
            }
            NewDataSourceComboBox4();
            var dataSource2 = comboBox4.DataSource as List<Specification>;
            if (dataSource2 != null)
            {
                var Item2 = dataSource2.FirstOrDefault(item => item.Name == dataGridView2.SelectedRows[0].Cells[3].Value.ToString());
                comboBox4.SelectedItem = Item2;
            }
            dateTimePicker2.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            maskedTextBox4.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void FilterData()
        {
            filter = String.Empty;

            if (!String.IsNullOrEmpty(maskedTextBox1.Text))
            {
                filter += String.Format($"convert(Column1, 'System.String') like '{maskedTextBox1.Text}%'");
            }
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                if (!String.IsNullOrEmpty(filter)) filter += " AND ";
                filter += String.Format($"convert(Column2, 'System.String') like '{textBox1.Text}%'");
            }
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                if (!String.IsNullOrEmpty(filter)) filter += " AND ";
                filter += String.Format($"convert(Column3, 'System.String') like '{comboBox1.Text.ToString()}%'");
                if (!String.IsNullOrEmpty(comboBox2.Text))
                {
                    if (!String.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += String.Format($"convert(Column4, 'System.String') like '{comboBox2.Text.ToString()}%'");
                }
            }
            if (dateTimePicker1.Checked && !checkBox1.Checked)
            {
                if (!String.IsNullOrEmpty(filter)) filter += " AND ";
                filter += String.Format($"convert(Column5, 'System.String') like '{dateTimePicker1.Value.ToString("dd.MM.yyyy")}%'");
            }
            if (!String.IsNullOrEmpty(maskedTextBox2.Text))
            {
                if (!String.IsNullOrEmpty(filter)) filter += " AND ";
                string maskedText = maskedTextBox2.Text.Split(" ")[0];
                filter += String.Format($"convert(Column6, 'System.String') like '{maskedText}%'");
            }

            if (dataView != null)
            {
                dataView.RowFilter = filter;
            }
        }

        private bool CheckValidating()
        {
            string checkRecordBook = maskedTextBox3.Text;

            foreach (DataGridViewRow row in dataGridView2.Rows)
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


        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;

            // Цвет вкладок
            Color backColor = Color.DarkSeaGreen;

            // Рисуем фон вкладки
            e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);

            // Рисуем текст
            string tabText = tabControl.TabPages[e.Index].Text;
            TextRenderer.DrawText(e.Graphics, tabText, tabControl.Font, e.Bounds, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewDataSourceComboBox2();
            FilterData();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewDataSourceComboBox4();
            FilterData();
        }

        private void filter_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRowForTable2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox3.Text == String.Empty || textBox2.Text == String.Empty || comboBox3.SelectedIndex == -1 ||
                comboBox4.SelectedIndex == -1 || maskedTextBox4.Text.Split(" ")[0] == String.Empty)
            {
                MessageBox.Show("Заполните все поля для добавления.");
            }
            else if (CheckValidating())
            {

                addStudent.Invoke(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите студента для обновления.");
            }
            else
            {
                if (recordBook == oldRecordBook)
                {
                    updateStudent.Invoke(sender, e);
                }
                else if (CheckValidating())
                {
                    updateStudent.Invoke(sender, e);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите студента для удаления.");
            }
            else
            {
                deleteStudent.Invoke(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = String.Empty;
            textBox1.Text = String.Empty;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            maskedTextBox2.Text = String.Empty;
            checkBox1.Checked = false;
            filter = String.Empty;
            dataView.RowFilter = filter;
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
