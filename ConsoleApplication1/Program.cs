using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var offset = new TimeSpan(0, 5, 0, 0, 0);

            var range1 = new TimeOfDayWeekRange(
                new TimeOfDayWeek(TimeSpan.FromHours(20), DayOfWeek.Monday),
                new TimeOfDayWeek(TimeSpan.FromHours(23), DayOfWeek.Monday)
            );
            var range2 = new TimeOfDayWeekRange(
                new TimeOfDayWeek(TimeSpan.FromHours(8), DayOfWeek.Tuesday),
                new TimeOfDayWeek(TimeSpan.FromHours(16), DayOfWeek.Tuesday)
            );
            var range3 = new TimeOfDayWeekRange(
                new TimeOfDayWeek(TimeSpan.FromHours(8), DayOfWeek.Wednesday),
                new TimeOfDayWeek(TimeSpan.FromHours(16), DayOfWeek.Wednesday)
            );
            var range4 = new TimeOfDayWeekRange(
                new TimeOfDayWeek(TimeSpan.FromHours(8), DayOfWeek.Thursday),
                new TimeOfDayWeek(TimeSpan.FromHours(16), DayOfWeek.Thursday)
            );
            var range5 = new TimeOfDayWeekRange(
                new TimeOfDayWeek(TimeSpan.FromHours(8), DayOfWeek.Friday),
                new TimeOfDayWeek(TimeSpan.FromHours(16), DayOfWeek.Friday)
            );
            var range6 = new TimeOfDayWeekRange(
                new TimeOfDayWeek(TimeSpan.FromHours(8), DayOfWeek.Saturday),
                new TimeOfDayWeek(TimeSpan.FromHours(16), DayOfWeek.Saturday)
            );
            var range7 = new TimeOfDayWeekRange(
                new TimeOfDayWeek(TimeSpan.FromHours(8), DayOfWeek.Sunday),
                new TimeOfDayWeek(TimeSpan.FromHours(16), DayOfWeek.Sunday)
            );

            var ranges = new[] { range1, range2, range3, range4, range5, range6, range7 };

            var r1 = ranges.Select(r => r.AddOffset(offset)).ToList();
            var r2 = r1[0].AddOffset(TimeSpan.FromHours(10)).IsOverlapping(r1[1]);
        }
    }
}
