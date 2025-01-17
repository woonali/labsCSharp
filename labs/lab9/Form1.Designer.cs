namespace lab9
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(15, 15);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(763, 612);
            listView1.TabIndex = 0;
            listView1.TileSize = new Size(700, 100);
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "№ студенческого билета";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ФИО студента";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Направление обучения";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(786, 15);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(426, 336);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Изменение данных";
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Location = new Point(225, 281);
            button2.Name = "button2";
            button2.Size = new Size(194, 47);
            button2.TabIndex = 8;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Location = new Point(5, 281);
            button1.Name = "button1";
            button1.Size = new Size(194, 47);
            button1.TabIndex = 7;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(5, 232);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(412, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(5, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(412, 31);
            textBox1.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BeepOnError = true;
            maskedTextBox1.Location = new Point(5, 72);
            maskedTextBox1.Mask = "00000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(412, 31);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 197);
            label3.Name = "label3";
            label3.Size = new Size(204, 25);
            label3.TabIndex = 3;
            label3.Text = "Направление обучения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 117);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 2;
            label2.Text = "ФИО студента";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 37);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 1;
            label1.Text = "№ студенческого билета";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(786, 359);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(437, 268);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Управление файлами";
            // 
            // button5
            // 
            button5.BackColor = Color.LightSteelBlue;
            button5.Location = new Point(236, 192);
            button5.Name = "button5";
            button5.Size = new Size(194, 47);
            button5.TabIndex = 4;
            button5.Text = "Экспорт";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSteelBlue;
            button4.Location = new Point(7, 192);
            button4.Name = "button4";
            button4.Size = new Size(194, 47);
            button4.TabIndex = 3;
            button4.Text = "Импорт";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSteelBlue;
            button3.Location = new Point(128, 139);
            button3.Name = "button3";
            button3.Size = new Size(194, 47);
            button3.TabIndex = 2;
            button3.Text = "Обзор";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(7, 91);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(423, 31);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 43);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 0;
            label4.Text = "Путь к файлу";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1225, 640);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button3;
        private TextBox textBox3;
        private Label label4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
