﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newdemo
{
    internal class Employee
    {
        public string FirstName { get; set; } = null;
        public string LastName { get; set; } = null;
         
        public Department Department { get; set; }


    }
    class Department
    {
        public int code { get; set; }
        public string name { get; set; }
    }
}
