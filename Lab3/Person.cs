﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Person
    {
        private string name;
        private int age;
        private int stash;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public Person() { }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
