using System;
using System.Collections.Generic;
using System.Text;

namespace Kitm
{
    public class Teacher : Human, ITeach
    {
        public Teacher(string name) : base(name)
        {
     
        }

        public int RoomNumber { get; set; }
        public bool IsMan { get; }
        List<Student>Students { get; set; }

        public void Teachkids()
        {
            Console.WriteLine("I am good with teaching kids");
        }

    }
}
