using System;
using System.Collections.Generic;
using System.Text;

namespace SAL_Module3
{
    class Degree
    {
        public string Name { get; }
        public Course DegreeCourse { get; set; }

        public Degree(string name)
        {
            this.Name = name;
        }

        public void AddCourse(Course course)
        {
            this.DegreeCourse = course;
        }
    }
}
