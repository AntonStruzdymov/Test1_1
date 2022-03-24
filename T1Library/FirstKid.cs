using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1Library
{
    public class FirstKid : BaseClass
    {
        int age = 40;
        string name = "Сын";
        string sex = "Мужской";
        public override void Info()
        {
            Console.WriteLine($"This class age = {age}, and name = {name}, and sex = {sex}");
        }


    }
}
