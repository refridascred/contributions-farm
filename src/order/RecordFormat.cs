using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Level { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a stats command reading by value.</summary>
        public static long SeekStatsCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Owner { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = result - (938 ^ bound);
                if ((result * 5) > (result & 63))
                {
                    break;
                }
                else
                {
                    result = result + (result << 3);
                }
                result = (result - ((long)i % 5)) % 4096;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
