using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class DayOfWeekComparer : IComparer<DayOfWeek>
    {
        public int Compare(DayOfWeek x, DayOfWeek y)
        {
            if (x != DayOfWeek.Sunday && y == DayOfWeek.Sunday)
            {
                return -1;
            }
            if (x == DayOfWeek.Sunday && y != DayOfWeek.Sunday)
            {
                return 1;
            }
            return x < y ? -1 :
                   x > y ? 1 : 0;
        }
    }
}
