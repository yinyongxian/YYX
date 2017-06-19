using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
