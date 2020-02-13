using System;

namespace SAL_Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a UProgram object called Information Technology.

            UProgram uProgram = new UProgram(" Information Technology");

            //Instantiate three Student objects.

            Student student1 = new Student("Shweta", "Rajvanshi");
            Student student2 = new Student("Tanu", "Aggarwal");
            Student student3 = new Student("Supra", "Singh");

            //Instantiate a Course object called Programming with C#.

            Course course = new Course("Programming with C#");

            // Add your three students to this Course object.

            course.AddStudent(student1);
            course.AddStudent(student2);
            course.AddStudent(student3);


            //Instantiate at least one Teacher object.
            Teacher teacher = new Teacher("Malou", "Leaonardo");

            //Add that Teacher object to your Course object.
            course.AddTeacher(teacher);

            //Instantiate a Degree object, such as Bachelor.
            Degree bachelor = new Degree("bachelor of science");

            //Add your Course object to the Degree object.
            bachelor.Addcourse(course);

            //Add the Degree object to the UProgram object.
            uProgram.AddDegree(bachelor);


            //Using Console.WriteLine statements, output the following information to the console window:
            //The name of the program and the degree it contains
            //The name of the course in the degree
            //The count of the number of students in the course.

            Console.WriteLine("The Program is {0} and its degrees are:", uProgram.ProgramName);
            foreach (Degree d in uProgram.Degrees) Console.WriteLine("\t {0}", d.DegreeName);
            Console.WriteLine();
            Console.WriteLine("The first degree is {0} and its available courses are:", bachelor.DegreeName);
            foreach (Course c in bachelor.AvailableCourses) Console.WriteLine("\t {0}", c.CourseName);
            Console.WriteLine();
            Console.WriteLine("Total number of students: {0}", Student.StudentCount);


        }
    }
}