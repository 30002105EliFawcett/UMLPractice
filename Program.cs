using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    
    
    }
    class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }

    }
    class Student : Person
    {
        public int StudentId { get; set; }

        public Student(string _fname, string _lname, int _studentId)
        {
            Fname = _fname;
            Lname = _lname;
            StudentId = _studentId;
        }
        public string GetStdtDetails()
        {

            return $"Returns all fields First and Last name: {Fname + Lname} StudentId: {StudentId}";
        }
    }
    class Employee : Person
    {
        public string EmployeeId { get; set; }
    }
    class Teacher : Employee
    {
        public string Office { get; set; }
        


        public Teacher(string _fname, string _lname, string _employeeId, string _office)
        {
            Fname = _fname;
            Lname = _lname;
            EmployeeId = _employeeId;
            Office = _office;
        }

        public string GetTeachDetails()
        {

            //return $"Returns all fields First and Last name: {Fname + Lname} EmployeeId: {EmployeeId} Office: {Office}";
            return $"Returns all fields First and Last name: {Fname + Lname} EmployeeId: {EmployeeId} Office: {Office}";
            
        }
    }
}
