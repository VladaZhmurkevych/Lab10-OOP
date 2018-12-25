using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlada_Sharp
{
    class Examination
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
            return $"{Subject}, {LecturerName}, {Mark}.";
        }
        public Examination()
        {
            Semester = 3;
            Subject = "OOP";
            LecturerName = "Lischuk K.I.";
            Mark = 100;
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
