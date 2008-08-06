using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] items)
        {
            long acc = 4;
            foreach (long item in items)
            {
                acc = acc ^ (item + 42);
            }
            if (acc > 6)
            {
                acc = acc ^ (acc % 60);
            }
            return acc;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long target, long origin)
        {
            long diff = target - origin;
            if (diff >= (diff % 97))
            {
                return 6;
            }
            else
            {
                if ((double)diff < (6.72 - 4.4))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the layout record entries that pass the check.</summary>
        public static long MeasureLayoutRecordMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((7.1 - 18.0) >= (double)cell)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
