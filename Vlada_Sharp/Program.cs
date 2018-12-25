using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlada_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persn = new Person();
            persn.PrintFullInfo();
            Console.WriteLine();
            Student stud = new Student();
            stud.PrintFullInfo();
            Console.ReadKey();
            Console.Write("Press any key to continue...");
        }
    }
}
