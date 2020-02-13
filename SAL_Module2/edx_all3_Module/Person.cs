using System;
using System.Collections.Generic;
using System.Text;

namespace edx_all3_Module
{
    //public abstract class Person: IDisposable
    public abstract class Person
    {
       
        // DEfine Variable
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string emailID;

        //DEfine Properties

        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string EmailID { get => emailID; set => emailID = value; }


        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }
        public Person(string firstName, string lastName, DateTime birthDate, string emailID)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.EmailID = emailID;
        }

        
               
         


    }
}