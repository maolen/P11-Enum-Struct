using System;
using System.Collections.Generic;
using System.Text;

namespace EnumStruct
{
    public struct Employee
    {
        const int SIZE = 3;
        public string Name { get; set; }
        public Vacancies Vacancy { get; set; }
        public int Salary { get; set; }
        private int[] _hiringDate;
        public int[] HiringDate
        {
            get
            {
                if (_hiringDate == null)
                {
                    _hiringDate = new int[SIZE];
                }
                return _hiringDate;
            }
            set
            {
                if (_hiringDate == null)
                {
                    _hiringDate = new int[SIZE];
                }
                _hiringDate = value;
            }
        }
    }
}
