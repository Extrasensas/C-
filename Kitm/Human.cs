using System;
using System.Collections.Generic;
using System.Text;

namespace Kitm
{
    public class Human
    {
        public Human(string name)
        {
            ID = Guid.NewGuid();
            Name = name;
        }
                              
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public Guid ID { get; set; }

    }
}
