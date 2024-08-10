using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPRacticeInheritance
{
    public class Teacher : BasePerson
    {
        private double _salary;

        public double Salary
        {
            get { return _salary; }

            set { _salary = value; }
        }


        public Teacher(string name, string surname, double salary)
        {
            _name = name;
            _surname = surname;
           Salary = salary;
        }

        public Teacher() { }

        public void displayTeacher()
        {
          


            Console.WriteLine("Teacher Name:" + _name + "\nTeacher Surname:" + _surname + "\nSalary:" + Salary + "\n");

        }

    }
}



