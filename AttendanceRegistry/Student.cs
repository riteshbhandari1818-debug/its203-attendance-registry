using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceRegistry
{
    public class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }

        public Student(string studentId, string name)
        {
            if (string.IsNullOrWhiteSpace(studentId))
                throw new ArgumentException("Student ID cannot be empty.");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Student name cannot be empty.");

            StudentId = studentId;
            Name = name;
        }

        public override string ToString()
        {
            return $"{StudentId} - {Name}";
        }
    }
}