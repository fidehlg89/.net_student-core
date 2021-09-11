using System;

namespace students_core.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public char Sex { get;  set; }
        public DateTime BirthDate { get; set; }
    }
}