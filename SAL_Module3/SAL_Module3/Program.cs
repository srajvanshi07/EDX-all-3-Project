using System;

namespace SAL_Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course("Programming with C#");
            Student student1 = new Student(@"C:\Users\srajvanshi\source\repos\Self-Assessment Lab\Delete\student1.txt");
            course.AddStudent(student1);
            Student student2 = new Student(@"C:\Users\srajvanshi\source\repos\Self-Assessment Lab\Delete\student2.txt");
            course.AddStudent(student2);
            Student student3 = new Student(@"C:\Users\srajvanshi\source\repos\Self-Assessment Lab\Delete\student3.txt");
            course.AddStudent(student3);
            Teacher teacher1 = new Teacher(@"C:\Users\srajvanshi\source\repos\Self-Assessment Lab\Delete\teacher1.txt", false);
            course.AddTeacher(teacher1);
            Degree degree = new Degree("Bachelor");
            degree.AddCourse(course);
            UProgram uprogram = new UProgram("Information Technology");
            uprogram.AddDegree(degree);
            Console.WriteLine("Program Name =  " + uprogram.Name);
            Console.WriteLine("Degree Name =  " + uprogram.Degrees[0].Name);
            Console.WriteLine("Course Name =  " + uprogram.Degrees[0].DegreeCourse.Name);
            Console.WriteLine("Student Count =  " + uprogram.Degrees[0].DegreeCourse.Students.Count);
            Console.WriteLine("Student1 Name =  " + uprogram.Degrees[0].DegreeCourse.Students[0].Name);
            Console.WriteLine("Student1 Email =  " + uprogram.Degrees[0].DegreeCourse.Students[0].Email);
            student1.Dispose();
            student2.Dispose();
            student3.Dispose();
            teacher1.Dispose();
        }
    }
}
