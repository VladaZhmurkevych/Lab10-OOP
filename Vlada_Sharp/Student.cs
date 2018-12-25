using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlada_Sharp
{
    class Student:Person
    {
        public enum Education { Master, Bachelor, SecondEducation, PhD};
        public Education QualifictionLevel { get; set; }
        public string Group { get; set; }
        public string MarkBook { get; set; }
        public List<Examination> DoneCredits { get; set; }
        public double AverageValue { get; private set; }
        public void AddExams(Examination[] examList)
        {
            foreach (Examination e in examList) {
                if (e.Mark > 60) {
                    DoneCredits.Add(e);
                }
            }
        }
        public override string ToString()
        {
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
        }
        public void calculateAverageValue() {
            double count = 0;
            foreach (Examination exam in DoneCredits) {
                count += exam.Mark;
            }
            AverageValue = count / DoneCredits.Count();
        }
        public Student( string name, string surname,DateTime bornDate, Education qualificationLevel, string group, string markbook) {
            Name = name;
            Surname = surname;
            _bornDate = bornDate;
            QualifictionLevel = qualificationLevel;
            Group = group;
            MarkBook = markbook;
        }
        public Student() {
            Name = "Den";
            Surname = "Wilson";
            _bornDate = new DateTime(1998, 11, 13);
            QualifictionLevel = Education.Bachelor;
            Group = "it-71";
            MarkBook = "it-7104";
        }

    }
}
