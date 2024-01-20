using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)

        {
            string name = "Kavindu";
            int age = 19;

            Console.WriteLine("There once was a man named " + name);
            Console.WriteLine("He was" + age + " years ald");
             name = "Chathurya";
            Console.WriteLine("He realy liked the name " + name);
            Console.WriteLine("But didn't like being " + age);

            Console.ReadLine();
        }
    }
}
