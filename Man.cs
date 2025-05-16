using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_practicum
{
    class Man
    {
        public string name;

        public delegate void MethodContainer();
        public event MethodContainer Event1;
        public event MethodContainer Event2;

        public void Method1()
        {
            Console.WriteLine(name + "проходит");
            Event1 -= Method1;
            Event1 -= Method2;
        }        
        public void Method2()
        {
            Console.WriteLine(name + "cтоит");
        }
    }
}
