using System;

namespace YYX.Test
{
    [Serializable]
    public class Person
    {
        public Person()
        {
            Name = string.Empty;
            Age = 0;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
