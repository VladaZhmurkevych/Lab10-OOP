using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlada_Sharp
{
    class Examination : IMarkName, IComparable
    {
        private int _semester;
        public int Semester
        {
            get { return _semester; }
            set
            {
                if (value > 0 && value < 13)
                    _semester = value;
            }
        }
        public string Subject { get; set; }
        public string LecturerName { get; set; }
        public int Mark { get; set; }
        public string CreditType { get; set; }
        public DateTime CreditDate { get; set; }
        public override string ToString()
        {
            return $"Semestr:{Semester} - {Subject}, {LecturerName}, {Mark}.";
        }

        public string NationalScaleName()
        {
            if (Mark <= 100 && Mark >= 95)
            {
                return "Excellent";
            }
            else if (Mark <= 94 && Mark >= 85)
            {
                return "Very good";
            }

            else if (Mark <= 84 && Mark >= 75)
            {
                return "Good";
            }
            else if (Mark <= 74 && Mark >= 65)
            {
                return "Satisfactory";
            }
            else if (Mark <= 64 && Mark >= 60)
            {
                return "Satisfactory (satisfy minimum criteria)";
            }
            else if (Mark < 60 && Mark >= 35)
            {
                return "Unsatisfactory";
            }
            else 
            {
                return "Fail (additional work is required)";
            }
        }

        public string EctsScaleName()
        {
            if (Mark <= 100 && Mark >= 95)
            {
                return "A";
            }
            else if (Mark <= 94 && Mark >= 85) {
                return "B";
            }
            else if (Mark <= 84 && Mark >= 75)
            {
                return "C";
            }
            else if (Mark <= 74 && Mark >= 65)
            {
                return "D";
            }
            else if (Mark <= 64 && Mark >= 60)
            {
                return "E";
            }
            else if (Mark <= 59 && Mark >= 35)
            {
                return "Fx";
            }
            else //(Mark <= 34 && Mark >= 0)
            {
                return "F";
            }
        }

        public int CompareTo(object obj)
        {
            Examination exam = obj as Examination;
            if (obj is null)
                throw new ApplicationException("Compare To method: obj is null");

            return this.Semester.CompareTo(exam.Semester);
        }

        public Examination()
        {
            Semester = 3;
            Subject = "OOP";
            LecturerName = "Lischuk K.I.";
            Mark = 94;
            CreditType = "Def";
            CreditDate = new DateTime(2019, 01, 09);
        }
        public Examination(int semester, string subject, string lecturerName, int mark, string creditType, DateTime creditTime)
        {
            Semester = semester;
            Subject = subject;
            LecturerName = lecturerName;
            Mark = mark;
            CreditType = creditType;
            CreditDate = creditTime;
        }
    }
}
