using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public  class Name
    {
        
        private string sName { get; set; }
               
        public Name(string studentname)
        {

            sName = studentname;

            List<string> studentnamelist     = new List<string>();
            studentnamelist .Add("Rahul");
            studentnamelist.Add("Taleb");
            studentnamelist.Add("Faizal");
            studentnamelist.Add("John");



        
            foreach (var item in studentnamelist.Where(x => x.StartsWith(sName)))
            {
                Console.WriteLine("The student name is  :"+item);
                Console.ReadLine();
            }


        }
    }
}
