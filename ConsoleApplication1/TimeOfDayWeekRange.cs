using System;

namespace ConsoleApplication1
{
    public class TimeOfDayWeekRange
    {
        public TimeOfDayWeek Left { get; }

        public TimeOfDayWeek Right { get; }

        public TimeOfDayWeekRange(TimeOfDayWeek left, TimeOfDayWeek right)
        {
            Left = left;
            Right = right;
        }

        public bool IsOverlapping(TimeOfDayWeekRange timeOfDayWeekRange)
        {
            var first = this;
            var second = timeOfDayWeekRange;
            if (first.Left > second.Left)
            {
                first = timeOfDayWeekRange;
                second = this;
            }
            return first.Right >= second.Left;
        }

        public TimeOfDayWeekRange AddOffset(TimeSpan timeSpan)
        {
            return new TimeOfDayWeekRange(Left.AddOffset(timeSpan), Right.AddOffset(timeSpan));
        }
    }
}
