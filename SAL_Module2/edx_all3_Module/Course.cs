﻿using System;
using System.Collections.Generic;
using System.Text;

namespace edx_all3_Module
{
    class Course
    {
        // DEclare variable
        private string courseName;
        private double credits;
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();
        // DEclare properties

        public string CourseName { get => courseName; set => courseName = value; }
        public double Credits { get => credits; set => credits = value; }
        internal List<Teacher> Teachers { get => teachers; set => teachers = value; }
        internal List<Student> Students { get => students; set => students = value; }

        //Connstructor
        public Course(string courseName)
        {
            this.CourseName = courseName;
        }
        public Course(string courseName, double credits)
        {
            this.CourseName = courseName;
            this.Credits = credits;
        }
        public Course(string courseName, double credits, List<Teacher> teachers, List<Student> students)
        {
            this.CourseName = courseName;
            this.Credits = credits;
            this.Teachers = teachers;
            this.Students = students;
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

    }
}
