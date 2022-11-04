using System;
using System.Collections.Generic;
using System.Text;

namespace Kitm
{

    interface IErasmusStudent
    {
        public bool IsErasmus { get; set; }
    }
    public class Student : Human, IErasmusStudent
    {
        public Student(string name)
            :base(name)
        {

        }
        
        public Guid StudentID { get; set; }
        public Teacher Teacher { get; set; }
        public bool IsErasmus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
