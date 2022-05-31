using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public int Number { get; set; }
        public char Letter { get; set; }
        public List<Student> Students { get; set; }
        public List<ClassSubject> ClassSubjects { get; set; }
    }
}
