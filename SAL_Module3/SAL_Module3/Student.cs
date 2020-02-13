using System;
using System.Collections.Generic;
using System.Text;

namespace SAL_Module3
{
    class Student : Person
    {
        public static int Count;
        public int Id { get; }
        public Student(string fileName) : base(fileName)
        {
            this.Id = GetId();
        }

        private int GetId()
        {
            Count++;
            return Count;
        }
    }
}
