using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1Library
{
    public class SecondKid : BaseClass
    {
        int age = 20;
        string name = "Дочь";
        string haircolor = "Блонд";
        public override void Info()
        {
            Console.WriteLine($"This class age = {age}, and name = {name}, and sex = {haircolor}");
        }
    }
}
