using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public class MainForm : Form
    {
        private SchoolManagementSystem system;
        private ListBox studentListBox;
        private TextBox nameTextBox;
        private TextBox classNameTextBox;
        private TextBox gradeTextBox;

        public MainForm(SchoolManagementSystem system)
        {
            this.system = system;
            system.LoadData();

            InitializeComponents();
            UpdateStudentList();
        }

        private void InitializeComponents()
        {
            // Main Form settings
            Text = "School Management System";
            Width = 500;
            Height = 400;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            CenterToScreen();

            // Student List
            studentListBox = new ListBox();
            studentListBox.Width = 200;
            studentListBox.Height = 300;
            studentListBox.Location = new Point(10, 10);
            Controls.Add(studentListBox);

            // Name Label
            Label nameLabel = new Label();
            nameLabel.Text = "Name:";
            nameLabel.Location = new Point(220, 10);
            Controls.Add(nameLabel);

            // Name TextBox
            nameTextBox = new TextBox();
            nameTextBox.Width = 200;
            nameTextBox.Location = new Point(220, 30);
            Controls.Add(nameTextBox);

            // Class Label
            Label classLabel = new Label();
            classLabel.Text = "Class:";
            classLabel.Location = new Point(220, 60);
            Controls.Add(classLabel);

            // Class TextBox
            classNameTextBox = new TextBox();
            classNameTextBox.Width = 200;
            classNameTextBox.Location = new Point(220, 80);
            Controls.Add(classNameTextBox);

            // Grade Label
            Label gradeLabel = new Label();
            gradeLabel.Text = "Grade:";
            gradeLabel.Location = new Point(220, 110);
            Controls.Add(gradeLabel);

            // Grade TextBox
            gradeTextBox = new TextBox();
            gradeTextBox.Width = 200;
            gradeTextBox.Location = new Point(220, 130);
            Controls.Add(gradeTextBox);

            // Add Button
            Button addButton = new Button();
            addButton.Text = "Add";
            addButton.Width = 80;
            addButton.Location = new Point(220, 170);
            addButton.Click += AddButton_Click;
            Controls.Add(addButton);

            // Edit Button
            Button editButton = new Button();
            editButton.Text = "Edit";
            editButton.Width = 80;
            editButton.Location = new Point(310, 170);
            editButton.Click += EditButton_Click;
            Controls.Add(editButton);

            // Delete Button
            Button deleteButton = new Button();
            deleteButton.Text = "Delete";
            deleteButton.Width = 80;
            deleteButton.Location = new Point(400, 170);
            deleteButton.Click += DeleteButton_Click;
            Controls.Add(deleteButton);
        }

        private void UpdateStudentList()
        {
            studentListBox.Items.Clear();

            foreach (var student in system.GetStudents())
            {
                studentListBox.Items.Add($"{student.Name}, Class: {student.ClassName}, Grade: {student.Grade}");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string className = classNameTextBox.Text;
            int grade = int.Parse(gradeTextBox.Text);

            system.InsertStudent(name, className, grade);
            UpdateStudentList();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (studentListBox.SelectedItem != null)
            {
                int selectedIndex = studentListBox.SelectedIndex;
                Student student = system.GetStudents()[selectedIndex];

                string name = nameTextBox.Text;
                string className = classNameTextBox.Text;
                int grade = int.Parse(gradeTextBox.Text);

                system.EditStudent(student, name, className, grade);
                UpdateStudentList();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (studentListBox.SelectedItem != null)
            {
                int selectedIndex = studentListBox.SelectedIndex;
                Student student = system.GetStudents()[selectedIndex];

                system.DeleteStudent(student);
                UpdateStudentList();
            }
        }
    }
}
