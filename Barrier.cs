using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_practicum
{
    class Barrier
    {
        public delegate void MethodContainer();
        public event MethodContainer Event1;
        public event MethodContainer Event2;

        public void Method1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Закрыто.");
        }
        public void Method2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Открыто.");
        }
        public void Method3()
        {
            for (int i = 0; i < 11; i++)
            {

            }
            Random rnd = new Random();
            int eventChoose = rnd
        }
    }
}
