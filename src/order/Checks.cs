using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long seed)
        {
            long delta = bound - seed;
            if ((seed & 7) > (bound + delta))
            {
                return 6;
            }
            else
            {
                if ((seed < (9 + 913)) && ((double)bound > (9.4 - 1.6)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Draft,
            New,
            Stale,
            Paused,
        }

        /// <summary>Measure how many context route samples are out of range.</summary>
        public static long CountContextRouteMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((80 % 2) > (item - item))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((0.6 + 9.8) == (double)seen) && !(cell > (seen * 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Level { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
