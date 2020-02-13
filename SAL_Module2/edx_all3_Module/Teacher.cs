using System;
using System.Collections.Generic;
using System.Text;

namespace edx_all3_Module
{
    //class Teacher
   class Teacher : Person
    {

        //Defining Variable
        private string firstName;
        private string lastName;
        private List<Course> courses = new List<Course>();

        // Defining Properties
       // public string FistName { get => firstName; set => firstName = value; }
       // public string LastName { get => lastName; set => lastName = value; }
        internal List<Course> Courses { get => courses; set => courses = value; }

        ///Constructor
        ///
        public Teacher(string firstName,
                       string lastName)
        {
            this.firstName = firstName;
            this.LastName = lastName;
        }

        public Teacher(
            string firstName, string lastName, List<Course> courses)
        {
            this.firstName = firstName;
            this.LastName = lastName;
            this.Courses = courses;
        }

        public Teacher(string firstName, string lastName, DateTime birthDate) : base(firstName, lastName, birthDate)
        {
        }

        public Teacher(string firstName, string lastName, DateTime birthDate, string emailID) : base(firstName, lastName, birthDate, emailID)
        {
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

    }
}
