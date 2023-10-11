﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {
        public string FullName { get; set; }
        public double GroupNo { get; set; }
        public double AvgPoint { get; set; }

        public Student(string fullName)
        {
            this.FullName = fullName;
        }
    }
}