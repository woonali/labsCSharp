namespace lab7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            recordBook = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            department = new DataGridViewTextBoxColumn();
            specification = new DataGridViewTextBoxColumn();
            dateOfAdmission = new DataGridViewTextBoxColumn();
            group = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { recordBook, fullName, department, specification, dateOfAdmission, group });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MinimumSize = new Size(1310, 388);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(1310, 388);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // recordBook
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            recordBook.DefaultCellStyle = dataGridViewCellStyle1;
            recordBook.FillWeight = 0.130737826F;
            recordBook.HeaderText = "№ студенческого билета";
            recordBook.MinimumWidth = 125;
            recordBook.Name = "recordBook";
            recordBook.ReadOnly = true;
            // 
            // fullName
            // 
            fullName.FillWeight = 434.388062F;
            fullName.HeaderText = "ФИО студента";
            fullName.MinimumWidth = 225;
            fullName.Name = "fullName";
            fullName.ReadOnly = true;
            // 
            // department
            // 
            department.FillWeight = 0.00627565524F;
            department.HeaderText = "Институт";
            department.MinimumWidth = 300;
            department.Name = "department";
            department.ReadOnly = true;
            // 
            // specification
            // 
            specification.FillWeight = 138.968964F;
            specification.HeaderText = "Направление";
            specification.MinimumWidth = 225;
            specification.Name = "specification";
            specification.ReadOnly = true;
            // 
            // dateOfAdmission
            // 
            dateOfAdmission.FillWeight = 21.3055F;
            dateOfAdmission.HeaderText = "Дата зачисления";
            dateOfAdmission.MinimumWidth = 120;
            dateOfAdmission.Name = "dateOfAdmission";
            dateOfAdmission.ReadOnly = true;
            // 
            // group
            // 
            group.FillWeight = 5.200463F;
            group.HeaderText = "Группа";
            group.MinimumWidth = 125;
            group.Name = "group";
            group.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(0, 406);
            groupBox1.MinimumSize = new Size(1109, 300);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1109, 300);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dateTimePicker1.Font = new Font("Segoe UI", 10.2F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(875, 96);
            dateTimePicker1.MinimumSize = new Size(205, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(205, 30);
            dateTimePicker1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10.2F);
            comboBox1.FormattingEnabled = true;
            comboBox1.ImeMode = ImeMode.Off;
            comboBox1.Location = new Point(468, 96);
            comboBox1.Margin = new Padding(3, 3, 45, 3);
            comboBox1.MinimumSize = new Size(366, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(366, 31);
            comboBox1.TabIndex = 7;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Font = new Font("Segoe UI", 10.2F);
            textBox1.Location = new Point(35, 96);
            textBox1.Margin = new Padding(3, 3, 35, 3);
            textBox1.MinimumSize = new Size(392, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 30);
            textBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 10.2F);
            textBox3.Location = new Point(875, 212);
            textBox3.MinimumSize = new Size(205, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 30);
            textBox3.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Bottom;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 10.2F);
            comboBox2.FormattingEnabled = true;
            comboBox2.ImeMode = ImeMode.Off;
            comboBox2.Location = new Point(468, 212);
            comboBox2.Margin = new Padding(3, 3, 45, 3);
            comboBox2.MinimumSize = new Size(366, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(366, 31);
            comboBox2.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Font = new Font("Segoe UI", 10.2F);
            textBox2.Location = new Point(35, 212);
            textBox2.Margin = new Padding(3, 3, 35, 3);
            textBox2.MinimumSize = new Size(392, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(392, 30);
            textBox2.TabIndex = 11;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(875, 161);
            label6.MinimumSize = new Size(65, 23);
            label6.Name = "label6";
            label6.Size = new Size(65, 23);
            label6.TabIndex = 6;
            label6.Text = "Группа";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(875, 43);
            label5.MinimumSize = new Size(144, 23);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 5;
            label5.Text = "Дата зачисления";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(468, 161);
            label4.MinimumSize = new Size(116, 23);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 4;
            label4.Text = "Направление";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(468, 43);
            label3.MinimumSize = new Size(80, 23);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 3;
            label3.Text = "Институт";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(35, 161);
            label2.MinimumSize = new Size(120, 23);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 2;
            label2.Text = "ФИО студента";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(35, 43);
            label1.Margin = new Padding(3, 0, 433, 0);
            label1.MinimumSize = new Size(206, 23);
            label1.Name = "label1";
            label1.Size = new Size(206, 23);
            label1.TabIndex = 1;
            label1.Text = "№ студенческого билета";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(1137, 406);
            groupBox2.MinimumSize = new Size(185, 300);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(185, 300);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Действие";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.RosyBrown;
            button3.Location = new Point(6, 202);
            button3.MinimumSize = new Size(173, 80);
            button3.Name = "button3";
            button3.Size = new Size(173, 80);
            button3.TabIndex = 2;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.RosyBrown;
            button2.Location = new Point(6, 116);
            button2.MinimumSize = new Size(173, 80);
            button2.Name = "button2";
            button2.Size = new Size(173, 80);
            button2.TabIndex = 1;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.RosyBrown;
            button1.Location = new Point(6, 30);
            button1.MinimumSize = new Size(173, 80);
            button1.Name = "button1";
            button1.Size = new Size(173, 80);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1334, 706);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn recordBook;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn department;
        private DataGridViewTextBoxColumn specification;
        private DataGridViewTextBoxColumn dateOfAdmission;
        private DataGridViewTextBoxColumn group;
    }
}
