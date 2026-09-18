using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceRegistry
{
    public enum AttendanceStatus
    {
        Present,
        Absent,
        Late
    }

    public class AttendanceRecord
    {
        public string StudentId { get; set; }
        public DateTime SessionDate { get; set; }
        public AttendanceStatus Status { get; set; }

        public AttendanceRecord(string studentId, DateTime sessionDate, AttendanceStatus status)
        {
            if (string.IsNullOrWhiteSpace(studentId))
                throw new ArgumentException("Student ID cannot be empty.");

            StudentId = studentId;
            SessionDate = sessionDate;
            Status = status;
        }

        public override string ToString()
        {
            return $"{StudentId} - {SessionDate:dd/MM/yyyy} - {Status}";
        }
    }
}