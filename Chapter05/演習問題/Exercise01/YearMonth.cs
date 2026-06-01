using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class YearMonth
    {
        public int Year { get; init; }
        public int Month { get; init; }
        // public int Is21Century { get; init; }
        public bool IsCentury => 2001 <= 2100;
    

       
    
    public YearMonth(int Year, int Month, int Is21Century)
        {
            Year = Year;
            Month = Month;
            Is21Century = Is21Century;
        }

        public YearMonth AddOneMonth(int Year, int Month)
        {

        }
    }
}

