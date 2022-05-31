using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}
