using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AttendanceRegistry
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private DataManager dataManager = new DataManager("students.csv", "attendance.csv");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student(txtStudentId.Text, txtName.Text);
                students.Add(student);
                dataManager.SaveStudents(students);
                lstStudents.Items.Add(student.ToString());

                txtStudentId.Clear();
                txtName.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input");
            }
        }
    }
}