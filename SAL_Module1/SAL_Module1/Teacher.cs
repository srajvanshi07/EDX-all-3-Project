using System;
using System.Collections.Generic;
using System.Text;

namespace SAL_Module1
{
    class Teacher
    {

        //Defining Variable
        private string firstName;
        private string lastName;
        private List<Course> courses = new List<Course>();

        // Defining Properties
        public string FistName { get=>firstName; set=>firstName=value; }
        public string LastName { get=>lastName; set=>lastName=value; }
        internal List<Course> Courses { get=>courses; set=>courses=value; }

            ///Constructor
            ///
        public Teacher(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.LastName = lastName;
        }

        public Teacher(string firstName,string lastName,List<Course> courses)
        {
            this.firstName = firstName;
            this.LastName = lastName;
            this.Courses = courses;
        }
        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

    }
}
