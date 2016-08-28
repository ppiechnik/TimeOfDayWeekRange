using System;

namespace ConsoleApplication1
{
    public static class TimeSpanExtension
    {
        public static TimeSpan TrimDays(this TimeSpan that)
        {
            return new TimeSpan(0, that.Hours, that.Minutes, that.Seconds, that.Milliseconds);
        }
    }
}
