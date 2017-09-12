﻿namespace YYX.Data
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
            : this(string.Empty, 0)
        {

        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
