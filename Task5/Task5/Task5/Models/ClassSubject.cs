﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.Models
{
    public class ClassSubject
    {
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
