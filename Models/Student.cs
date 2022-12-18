using System.ComponentModel.DataAnnotations;

namespace TP4.Models
{
    public class Student
    {
        public Student()
        {
        }

        public Student(int id, string first_name, string last_name, string phone_number, string university, string timestamp, string course)
        {
            Id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.phone_number = phone_number;
            this.university = university;
            this.timestamp = timestamp;
            this.course = course;
        }

        [Key] public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone_number { get; set; }
        public string university { get; set; }
        public string timestamp { get; set; }
        public string course { get; set; }
    }

}
