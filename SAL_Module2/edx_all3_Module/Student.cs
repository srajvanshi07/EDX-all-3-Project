using System;
using System.Collections.Generic;
using System.Text;

namespace edx_all3_Module
{
    // class Student
    class Student : Person
    {
        //variable
        private static int studentCount = 0;

        private string firstName;
        private string lastName;
        private List<Course> courses = new List<Course>();
        //Properties
       // public string FirstName { get => firstName; set => firstName = value; }
       // public string LastName { get => lastName; set => lastName = value; }
        internal List<Course> Courses { get => courses; set => courses = value; }
        public static int StudentCount { get => StudentCount1; }
        public static int StudentCount1 { get => StudentCount2; set => StudentCount2 = value; }
        public static int StudentCount2 { get => studentCount; set => studentCount = value; }

        //Constructor
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            StudentCount1++;
        }
        public Student(string firstName, string lastName, List<Course> courses)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Courses = courses;
            StudentCount1++;
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }
    }
}
