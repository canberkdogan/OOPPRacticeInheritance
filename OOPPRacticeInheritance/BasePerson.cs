using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPRacticeInheritance
{
    public class BasePerson
    {
        public string _name { get; set; }

        public string _surname { get; set; }


        public void displayInfo()
        {
            Console.WriteLine(_name + "  " + _surname);

        }
    }


}



  
       
        
    


