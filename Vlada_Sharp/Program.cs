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
            Console.WriteLine("Zhmurkevych Vladyslava, IP-72, 9 Variant");

            Console.WriteLine();
            Student edward = new Student("Edward", "Jackson", new DateTime(1998, 06, 14), Student.Education.Bachelor, "IP-71", "IP-7112");
            Console.WriteLine(edward.ToString());
            edward.AddExams(new Examination[]
            {
                new Examination(3, "OOP", "Lischuck K.I.", 96, "Def", new DateTime(2019, 01, 09)),
                new Examination(1, "Math", "Bodnarchuk K.K.", 100, "Def", new DateTime(2018, 01, 12)),
                new Examination(2, "DS", "Shymcovych V.I.", 86, "Def", new DateTime(2018, 06, 13)),
                new Examination(4, "Cryptography", "Isachenko G.L.", 75, "Def", new DateTime(2019, 06, 12)),
            });
            Console.WriteLine(edward.ToString());
            edward.PrintFullInfo();

            Console.WriteLine("Exercise 1(2): ");
            Person p1 = new Person("Robert", "Wilson", new DateTime(1999, 11, 18));
            Person p2 = new Person("Robert", "Wilson", new DateTime(1999, 11, 18));
            Person p3 = new Person("John", "Smith", new DateTime(1998, 10, 12));
            Console.WriteLine("Robert Wilson 18.11.1999 == Robert Wilson 18.11.1999 : " + (p1 == p2));
            Console.WriteLine("Robert Wilson 18.11.1999 == John Smith 12.10.1998 : " + (p1 == p3));
            Console.WriteLine("Robert Wilson 18.11.1999 != Robert Wilson 18.11.1999 : " + (p1 != p2));
            Console.WriteLine("Robert Wilson 18.11.1999 != John Smith 12.10.1998 : " + (p1 != p3));
            Console.WriteLine();

            Console.WriteLine("Exercise 2(3): ");
            Examination exam = new Examination();
            exam.Mark = 87;
            Console.WriteLine("Mark 87");
            Console.WriteLine("In national scale: {0}", exam.NationalScaleName());
            Console.WriteLine("In ECTS scale: {0}", exam.EctsScaleName());
            Console.WriteLine();

            Console.WriteLine("Exercise 3(5): ");
            Console.WriteLine("Exams with mark more than 85: ");
             foreach (Examination exm in edward.GetExaminations(86))
             {
                 Console.WriteLine(exm);
             }
            Console.WriteLine();

            Console.WriteLine("Exercise 4(10): ");
            Console.WriteLine("Exams sorted by semester: ");
            edward.GetCredits();

            Console.ReadKey();
            Console.Write("Press any key to continue...");
            
        }
    }
}
