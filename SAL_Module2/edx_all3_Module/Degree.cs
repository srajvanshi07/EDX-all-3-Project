using System;
using System.Collections.Generic;
using System.Text;

namespace edx_all3_Module
{
    class Degree
    {
        //Degree variable 
        private string degreeName;
        private double requiredCredit;
        private List<Course> availableCourses = new List<Course>();

        //DEgree Properties
        public string DegreeName { get => degreeName; set => degreeName = value; }
        public double RequiredCredit { get => requiredCredit; set => requiredCredit = value; }

        internal List<Course> AvailableCourses { get => availableCourses; set => availableCourses = value; }

        //Degree constructor
        public Degree(string degreeName)
        {
            this.DegreeName = degreeName;
        }
        public Degree(string degreeName, double requiredCredit)
        {
            this.DegreeName = degreeName;
            this.RequiredCredit = requiredCredit;
        }
        public Degree(string degreeName, double requiredCredit, List<Course> availableCourses)
        {
            this.DegreeName = degreeName;
            this.RequiredCredit = requiredCredit;
            this.AvailableCourses = availableCourses;
        }
        public void Addcourse(Course course)
        {
            AvailableCourses.Add(course);
        }




    }
}
