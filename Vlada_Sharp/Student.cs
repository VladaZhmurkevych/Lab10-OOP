using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlada_Sharp
{
    class Student : Person
    {
        public enum Education { Master, Bachelor, SecondEducation, PhD };
        public Education QualifictionLevel { get; set; }
        public string Group { get; set; }
        public string MarkBook { get; set; }
        public List<Examination> DoneCredits { get; set; }
        public double AverageValue { get; private set; }
        public void AddExams(Examination[] examList)
        {
            foreach (Examination e in examList)
            {
                if (e.Mark > 60)
                {
                    DoneCredits.Add(e);
                }
            }
        }
        public override string ToString()
        {
            //Console.WriteLine($"{Name}, {Surname}, {Group}");
            return $"{Name}, {Surname}, {Group}";
        }
        public override void PrintFullInfo()
        {
            Console.WriteLine("Name: {0}\n" +
            "Surname: {1}\n" +
            "Born Date: {2}\n" +
            "Qualifiction level: {3}\n" +
            "Group: {4}\n" +
            "Markbook: {5}"
            , Name, Surname, _bornDate.ToShortDateString(), QualifictionLevel, Group, MarkBook);
            for (int i = 0; i < DoneCredits.Count(); i++) {
                Console.WriteLine(DoneCredits[i]);
            }
            Console.WriteLine();
        }
        public void calculateAverageValue()
        {
            double count = 0;
            foreach (Examination exam in DoneCredits)
            {
                count += exam.Mark;
            }
            AverageValue = count / DoneCredits.Count();
        }
        public void GetCredits()
        {
            DoneCredits.Sort();
            foreach (var c in DoneCredits)
            {
                Console.WriteLine(c);
            }
        }
        public IEnumerable GetExaminations(int mark)
        {
            foreach (var exam in DoneCredits)
                if (exam.Mark >= mark)
                    yield return exam;
        }
        public Student(string name, string surname, DateTime bornDate, Education qualificationLevel, string group, string markbook)
        {
            Name = name;
            Surname = surname;
            _bornDate = bornDate;
            QualifictionLevel = qualificationLevel;
            Group = group;
            MarkBook = markbook;
            DoneCredits = new List<Examination>();
        }
        public Student()
        {
            Name = "Den";
            Surname = "Wilson";
            _bornDate = new DateTime(1998, 11, 13);
            QualifictionLevel = Education.Bachelor;
            Group = "it-71";
            MarkBook = "it-7104";
            DoneCredits = new List<Examination>();
        }
    }
}
