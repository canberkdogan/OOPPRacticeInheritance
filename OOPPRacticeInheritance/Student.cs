using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPRacticeInheritance
{
    public class Student : BasePerson
    {
        public int _studentNumber { get; set; }


        public Student(string name, string surname, int studentNumber)
        {
            _name = name;
            _surname = surname;
            _studentNumber = studentNumber;
        }

        public void displayInfo()
        {

            Console.WriteLine("Student Name:"+ _name +"\nStudent Surname:" + _surname + "\nStudent Number: " + _studentNumber + "\n" );

        }
    }
}