using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1Library
{
    public class BaseClass
    {
        public  int age = 60;
        public string name = "Папаня";
        public virtual void Info()
        {
            Console.WriteLine($"This class age = {age}, and name = {name}");
        }
    }
}
