namespace lab8.Views
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            button4 = new Button();
            maskedTextBox2 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            maskedTextBox4 = new MaskedTextBox();
            dateTimePicker2 = new DateTimePicker();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox2 = new TextBox();
            label11 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label12 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Honeydew;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(6, 250);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1238, 410);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Column1";
            Column1.HeaderText = "№ студенческого билета";
            Column1.MinimumWidth = 140;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Column2";
            Column2.HeaderText = "ФИО студента";
            Column2.MinimumWidth = 300;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Column3";
            Column3.HeaderText = "Институт";
            Column3.MinimumWidth = 200;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Column4";
            Column4.HeaderText = "Направление обучения";
            Column4.MinimumWidth = 180;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Column5";
            Column5.HeaderText = "Дата зачисления";
            Column5.MinimumWidth = 125;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Column6";
            Column6.HeaderText = "Группа";
            Column6.MinimumWidth = 100;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 4);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1235, 222);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(922, 82);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(283, 29);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Не учитывать дату при поиске";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += filter_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGreen;
            button4.Location = new Point(987, 179);
            button4.Name = "button4";
            button4.Size = new Size(218, 36);
            button4.TabIndex = 12;
            button4.Text = "Очистить фильтр";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = Color.Honeydew;
            maskedTextBox2.Location = new Point(924, 142);
            maskedTextBox2.Mask = "000-LLL";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(281, 31);
            maskedTextBox2.TabIndex = 11;
            maskedTextBox2.TextChanged += filter_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.Honeydew;
            dateTimePicker1.CalendarTitleBackColor = Color.MediumAquamarine;
            dateTimePicker1.Location = new Point(924, 53);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(279, 31);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += filter_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Honeydew;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(484, 142);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(384, 33);
            comboBox2.TabIndex = 9;
            comboBox2.SelectedIndexChanged += filter_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Honeydew;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(482, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(384, 33);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(927, 114);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 7;
            label6.Text = "Группа";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(922, 25);
            label5.Name = "label5";
            label5.Size = new Size(146, 25);
            label5.TabIndex = 6;
            label5.Text = "Дата зачисления";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(487, 114);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 5;
            label4.Text = "Направление";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 25);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 4;
            label3.Text = "Институт";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Honeydew;
            textBox1.Location = new Point(21, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 31);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += filter_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 114);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 2;
            label2.Text = "ФИО студента";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.Honeydew;
            maskedTextBox1.Location = new Point(19, 53);
            maskedTextBox1.Mask = "00000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(408, 31);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            maskedTextBox1.TextChanged += filter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 0;
            label1.Text = "№ студенческого билета";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(9, 4);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1235, 222);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(1089, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(139, 200);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGreen;
            button3.Location = new Point(6, 145);
            button3.Name = "button3";
            button3.Size = new Size(127, 45);
            button3.TabIndex = 2;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.Location = new Point(6, 83);
            button2.Name = "button2";
            button2.Size = new Size(127, 45);
            button2.TabIndex = 1;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Location = new Point(6, 21);
            button1.Name = "button1";
            button1.Size = new Size(127, 45);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.BackColor = Color.Honeydew;
            maskedTextBox4.Location = new Point(865, 168);
            maskedTextBox4.Mask = "000-LLL";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(191, 31);
            maskedTextBox4.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = Color.Honeydew;
            dateTimePicker2.Location = new Point(867, 83);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(189, 31);
            dateTimePicker2.TabIndex = 10;
            // 
            // comboBox4
            // 
            comboBox4.BackColor = Color.Honeydew;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(484, 168);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(321, 33);
            comboBox4.TabIndex = 9;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.Honeydew;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(484, 83);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(321, 33);
            comboBox3.TabIndex = 8;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(865, 129);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 7;
            label7.Text = "Группа";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(865, 40);
            label8.Name = "label8";
            label8.Size = new Size(146, 25);
            label8.TabIndex = 6;
            label8.Text = "Дата зачисления";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(484, 129);
            label9.Name = "label9";
            label9.Size = new Size(121, 25);
            label9.TabIndex = 5;
            label9.Text = "Направление";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(484, 40);
            label10.Name = "label10";
            label10.Size = new Size(83, 25);
            label10.TabIndex = 4;
            label10.Text = "Институт";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Honeydew;
            textBox2.Location = new Point(21, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(408, 31);
            textBox2.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 129);
            label11.Name = "label11";
            label11.Size = new Size(126, 25);
            label11.TabIndex = 2;
            label11.Text = "ФИО студента";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.BackColor = Color.Honeydew;
            maskedTextBox3.Location = new Point(21, 83);
            maskedTextBox3.Mask = "00000000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(408, 31);
            maskedTextBox3.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 40);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(214, 25);
            label12.TabIndex = 0;
            label12.Text = "№ студенческого билета";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1261, 706);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkSeaGreen;
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1253, 668);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Поиск";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkSeaGreen;
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1253, 673);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Изменение";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = Color.Honeydew;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10, Column11, Column12 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.Location = new Point(6, 250);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1238, 410);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Column1";
            Column7.HeaderText = "№ студенческого билета";
            Column7.MinimumWidth = 140;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "Column2";
            Column8.HeaderText = "ФИО студента";
            Column8.MinimumWidth = 200;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "Column3";
            Column9.HeaderText = "Институт";
            Column9.MinimumWidth = 200;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "Column4";
            Column10.HeaderText = "Направление обучения";
            Column10.MinimumWidth = 180;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.DataPropertyName = "Column5";
            Column11.HeaderText = "Дата зачисления";
            Column11.MinimumWidth = 125;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.DataPropertyName = "Column6";
            Column12.HeaderText = "Группа";
            Column12.MinimumWidth = 100;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1261, 706);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "StudentForm";
            Text = "Студенты";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private MaskedTextBox maskedTextBox4;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox2;
        private Label label11;
        private MaskedTextBox maskedTextBox3;
        private Label label12;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private GroupBox groupBox3;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private Button button4;
        private CheckBox checkBox1;
    }
}