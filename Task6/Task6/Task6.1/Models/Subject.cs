using System;
using System.Collections.Generic;
using System.Text;

namespace Task6._1.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public List<ClassSubject> ClassSubjects { get; set; }
    }
}
