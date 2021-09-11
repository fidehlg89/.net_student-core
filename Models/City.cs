using System;
using System.Collections.Generic;
using System.Linq;

namespace students_core.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}