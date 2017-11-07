using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        public static string UserWants { get; private set; }

        static void Main(string[] args)
        {
            //Name clsInst = new Name(studentname);
            //// clsInst.studentName();
            //UserNameWanted(UserWants);
            UserNameWanted(UserWants);
            
          }

        public static string UserNameWanted(string UserWants)
        {
            Console.WriteLine("Enter the first letter you want from the student list:");
            UserWants = Console.ReadLine();
            Name UserInput = new Name(UserWants);
            return UserWants;
        }
    }
}
