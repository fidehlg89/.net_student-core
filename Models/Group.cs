using System;
using System.Collections.Generic;
using System.Linq;

namespace students_core.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
    }
}