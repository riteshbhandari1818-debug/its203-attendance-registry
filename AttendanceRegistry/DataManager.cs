using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AttendanceRegistry
{
    public class DataManager
    {
        private readonly string studentsFilePath;
        private readonly string attendanceFilePath;

        public DataManager(string studentsFilePath, string attendanceFilePath)
        {
            this.studentsFilePath = studentsFilePath;
            this.attendanceFilePath = attendanceFilePath;
        }

        public List<Student> LoadStudents()
        {
            var students = new List<Student>();

            if (!File.Exists(studentsFilePath))
                return students;

            try
            {
                var lines = File.ReadAllLines(studentsFilePath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var parts = line.Split(',');
                    if (parts.Length < 2)
                        continue;

                    students.Add(new Student(parts[0].Trim(), parts[1].Trim()));
                }
            }
            catch (Exception)
            {
                // If the file is malformed or unreadable, return whatever was loaded so far
                // rather than crashing the application.
            }

            return students;
        }

        public void SaveStudents(List<Student> students)
        {
            var lines = students.Select(s => $"{s.StudentId},{s.Name}");
            File.WriteAllLines(studentsFilePath, lines);
        }

        public List<AttendanceRecord> LoadAttendance()
        {
            var records = new List<AttendanceRecord>();

            if (!File.Exists(attendanceFilePath))
                return records;

            try
            {
                var lines = File.ReadAllLines(attendanceFilePath);
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var parts = line.Split(',');
                    if (parts.Length < 3)
                        continue;

                    if (!DateTime.TryParse(parts[1].Trim(), out DateTime sessionDate))
                        continue;

                    if (!Enum.TryParse(parts[2].Trim(), out AttendanceStatus status))
                        continue;

                    records.Add(new AttendanceRecord(parts[0].Trim(), sessionDate, status));
                }
            }
            catch (Exception)
            {
                // Same reasoning as LoadStudents - fail gracefully, don't crash.
            }

            return records;
        }

        public void SaveAttendance(List<AttendanceRecord> records)
        {
            var lines = records.Select(r => $"{r.StudentId},{r.SessionDate:yyyy-MM-dd},{r.Status}");
            File.WriteAllLines(attendanceFilePath, lines);
        }
    }
}