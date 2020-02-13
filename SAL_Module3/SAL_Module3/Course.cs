using System;
using System.Collections.Generic;
using System.Text;

namespace SAL_Module3
{
    class Course
    {
        public string Name { get; }
        public IList<Student> Students { get; }
        public IList<Teacher> Teachers { get; }

        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        internal void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }
    }
}
