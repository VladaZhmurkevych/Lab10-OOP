using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlada_Sharp
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        protected DateTime _bornDate;
        public int BornDate
        {
            get
            {
                return _bornDate.Year;
            }
            set
            {
                if (value <= DateTime.Now.Year && value > 1900)
                {
                    int day = _bornDate.Day;
                    int month = _bornDate.Month;
                    _bornDate = new DateTime(value, month, day);
                }
            }
        }
        public virtual void PrintFullInfo()
        {
            Console.WriteLine("Name: {0}\n" +
                "Surname: {1}\n" +
                "Born Date: {2}", Name, Surname, _bornDate.ToShortDateString());
        }
        public Person()
        {
            Name = "Robert";
            Surname = "Smith";
            _bornDate = new DateTime(1999, 08, 22);
        }
        public Person(string name, string surname, DateTime bornDate)
        {
            Name = name;
            Surname = surname;
            _bornDate = bornDate;
        }
        public override bool Equals(object obj)
        {
            Person p = obj as Person;
            if (!(p is null))
            {
                if (this.Name == p.Name &&
                    this.Surname == p.Surname &&
                    this._bornDate == p._bornDate)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return !p1.Equals(p2);
        }
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Equals(p2);
        }
    }
}
