using System;

namespace ConsoleApplication1
{
    public class TimeOfDayWeek
    {
        public DayOfWeek DayOfWeek { get; }

        public TimeSpan TimeOfDay { get; }

        public TimeOfDayWeek AddOffset(TimeSpan timeSpan)
        {
            var newTimeOfDay = TimeOfDay.Add(timeSpan);
            var newDayOfWeek = (DayOfWeek)((newTimeOfDay.Days + (int)DayOfWeek) % 7);
            var newTimeWithOutDays = newTimeOfDay.TrimDays();


            return new TimeOfDayWeek(newTimeWithOutDays, newDayOfWeek);
        }

        public TimeOfDayWeek(TimeSpan timeOfDay, DayOfWeek dayOfWeek)
        {
            DayOfWeek = dayOfWeek;
            TimeOfDay = timeOfDay;
        }

        private static DayOfWeekComparer _dayOfWeekComparer = new DayOfWeekComparer();

        public override bool Equals(object obj)
        {
            if (!(obj is TimeOfDayWeek))
            {
                throw new InvalidOperationException();
            }
            var objAfterCast = obj as TimeOfDayWeek;
            return DayOfWeek == objAfterCast.DayOfWeek && TimeOfDay == objAfterCast.TimeOfDay;
        }

        public override int GetHashCode()
        {
            return DayOfWeek.GetHashCode() ^ TimeOfDay.GetHashCode();
        }

        public static bool operator ==(TimeOfDayWeek a, TimeOfDayWeek b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(TimeOfDayWeek a, TimeOfDayWeek b)
        {
            return !a.Equals(b);
        }

        public static bool operator >(TimeOfDayWeek a, TimeOfDayWeek b)
        {
            return a.DayOfWeek == b.DayOfWeek ? _dayOfWeekComparer.Compare(a.DayOfWeek, b.DayOfWeek) > 0 : a.DayOfWeek > b.DayOfWeek;
        }

        public static bool operator <(TimeOfDayWeek a, TimeOfDayWeek b)
        {
            return a.DayOfWeek == b.DayOfWeek ? _dayOfWeekComparer.Compare(a.DayOfWeek, b.DayOfWeek) < 0 : a.DayOfWeek < b.DayOfWeek;
        }

        public static bool operator >=(TimeOfDayWeek a, TimeOfDayWeek b)
        {
            return a.DayOfWeek == b.DayOfWeek ? _dayOfWeekComparer.Compare(a.DayOfWeek, b.DayOfWeek) >= 0 : a.DayOfWeek >= b.DayOfWeek;
        }

        public static bool operator <=(TimeOfDayWeek a, TimeOfDayWeek b)
        {
            return a.DayOfWeek == b.DayOfWeek ? _dayOfWeekComparer.Compare(a.DayOfWeek, b.DayOfWeek) <= 0 : a.DayOfWeek <= b.DayOfWeek;
        }
    }
}
