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
    

       
    
    public YearMonth(int Year, int Month)
        {
            Year = Year;
            Month =Month;
           
        }

        public bool Is21Century => 2001 <= Year && Year <= 2100;
        
            

        public YearMonth AddOneMonth()
        {
            if (Month == 12)
            {
                return new YearMonth(Year + 1, Month);
            }
            else
            {
                return new YearMonth(Year ,Month);
            }
            
        }
    }
}

