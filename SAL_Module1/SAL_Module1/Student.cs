using System;
using System.Collections.Generic;
using System.Text;

namespace SAL_Module1
{
    class Student
    {
        //variable
        private static int studentCount = 0;

        private string firstName;
        private string lastName;
        private List<Course> courses = new List<Course>();
         //Properties
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        internal List<Course> Courses { get => courses; set => courses = value; }
        public static int StudentCount { get => studentCount; }

        //Constructor
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            studentCount++;
        }
        public Student(string firstName, string lastName, List<Course> courses)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Courses = courses;
            studentCount++;
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }
    }
}
